using System;
using System.Drawing;
using System.IO;
using System.Threading;
using Colorful;
using Newtonsoft.Json;

namespace ConsoleApp1
{
	// Token: 0x02000005 RID: 5
	internal class Config
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000021A7 File Offset: 0x000003A7
		public static void printLogo()
		{
			Colorful.Console.Clear();
			Colorful.Console.WriteLine(Program.logo);
			Colorful.Console.WriteLine("");
			Colorful.Console.Write("[Orkn ONUK] ", Color.LightGoldenrodYellow);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D30 File Offset: 0x00000F30
		public static Config.configObject renewconfig(bool AskToSave)
		{
			Config.configObject configObject = new Config.configObject();
			Config.printLogo();
			Colorful.Console.WriteLine(" Kaç iş parçacığına ihtiyacın var?");
			configObject.threads = int.Parse(Colorful.Console.ReadLine());
			Config.printLogo();
			Colorful.Console.WriteLine("Proxyless kullanmak istermisn Y/N?");
			string a = Colorful.Console.ReadLine().ToLower();
			configObject.PROXYLESS = (a != "n");
			if (!configObject.PROXYLESS)
			{
				Config.printLogo();
				Colorful.Console.WriteLine("Proxileri apiden çekmek istermsin Y/N?");
				string a2 = Colorful.Console.ReadLine().ToLower();
				configObject.API = (a2 != "n");
				if (configObject.API)
				{
					Config.printLogo();
					Colorful.Console.WriteLine("Api link");
					configObject.API_LINK = Colorful.Console.ReadLine();
					Config.printLogo();
					Colorful.Console.WriteLine(":Kaç dakikada bir yenilemek itersin");
					configObject.API_REFRESH_TIME = int.Parse(Colorful.Console.ReadLine());
				}
			}
			Config.printLogo();
			Colorful.Console.WriteLine("Yanlış hitleri kaydedeyim mi Y/N?");
			string a3 = Colorful.Console.ReadLine().ToLower();
			configObject.INVALIDS = (a3 != "n");
			Config.printLogo();
			if (!AskToSave)
			{
				File.WriteAllText("config.json", JsonConvert.SerializeObject(configObject));
				Colorful.Console.WriteLine("Config kaydedildi!", Color.LawnGreen);
				Thread.Sleep(2000);
				return null;
			}
			Colorful.Console.WriteLine("Configi kaydetmek istermisin Y/N?");
			if (Colorful.Console.ReadLine().ToLower() != "n")
			{
				File.WriteAllText("config.json", JsonConvert.SerializeObject(configObject));
				Colorful.Console.WriteLine("Config kaydedildi!", Color.LawnGreen);
				return configObject;
			}
			return configObject;
		}

		// Token: 0x02000006 RID: 6
		public class configObject
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x0600000D RID: 13 RVA: 0x000021D1 File Offset: 0x000003D1
			// (set) Token: 0x0600000E RID: 14 RVA: 0x000021D9 File Offset: 0x000003D9
			public int threads { get; set; }

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600000F RID: 15 RVA: 0x000021E2 File Offset: 0x000003E2
			// (set) Token: 0x06000010 RID: 16 RVA: 0x000021EA File Offset: 0x000003EA
			public bool API { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000011 RID: 17 RVA: 0x000021F3 File Offset: 0x000003F3
			// (set) Token: 0x06000012 RID: 18 RVA: 0x000021FB File Offset: 0x000003FB
			public string API_LINK { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000013 RID: 19 RVA: 0x00002204 File Offset: 0x00000404
			// (set) Token: 0x06000014 RID: 20 RVA: 0x0000220C File Offset: 0x0000040C
			public int API_REFRESH_TIME { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x06000015 RID: 21 RVA: 0x00002215 File Offset: 0x00000415
			// (set) Token: 0x06000016 RID: 22 RVA: 0x0000221D File Offset: 0x0000041D
			public bool WEBHOOK { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000017 RID: 23 RVA: 0x00002226 File Offset: 0x00000426
			// (set) Token: 0x06000018 RID: 24 RVA: 0x0000222E File Offset: 0x0000042E
			public string WEBHOOK_LINK { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000019 RID: 25 RVA: 0x00002237 File Offset: 0x00000437
			// (set) Token: 0x0600001A RID: 26 RVA: 0x0000223F File Offset: 0x0000043F
			public bool INVALIDS { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600001B RID: 27 RVA: 0x00002248 File Offset: 0x00000448
			// (set) Token: 0x0600001C RID: 28 RVA: 0x00002250 File Offset: 0x00000450
			public bool PROXYLESS { get; set; }
		}
	}
}
