using System;
using System.Collections.Generic;
using System.Threading;
using Leaf.xNet;

namespace ConsoleApp1
{
	// Token: 0x02000010 RID: 16
	internal class Proxy
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public static bool updateList(string[] url)
		{
			Proxy.updating = true;
			Proxy.URL = url;
			Proxy.proxies.Clear();
			Proxy.proxyindex = 0;
			foreach (string address in Proxy.URL)
			{
				try
				{
					foreach (string text in new HttpRequest().Get(address, null).ToString().Split(new char[]
					{
						'\n'
					}))
					{
						if (text.Length > 7)
						{
							proxyObject item = new proxyObject(text.Trim(), true);
							Proxy.proxies.Add(item);
						}
					}
				}
				catch (Exception)
				{
				}
			}
			Proxy.updating = false;
			return Proxy.proxies.Count < 5;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000022ED File Offset: 0x000004ED
		public static void updateThread(object a)
		{
			for (;;)
			{
				Thread.Sleep(int.Parse(a.ToString()));
				Proxy.updateList(Proxy.URL);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003C74 File Offset: 0x00001E74
		public static proxyObject getProxy()
		{
			if (Proxy.proxies.Count < 5)
			{
				if (!Proxy.updating)
				{
					Proxy.updateList(Proxy.URL);
				}
				return null;
			}
			proxyObject result;
			try
			{
				int num;
				for (;;)
				{
					num = Proxy.proxyindex;
					if (num > Proxy.proxies.Count)
					{
						Proxy.proxyindex = 0;
					}
					else
					{
						Proxy.proxyindex++;
						if (Proxy.proxies[num].Working)
						{
							break;
						}
					}
				}
				result = Proxy.proxies[num];
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x04000021 RID: 33
		public static List<proxyObject> proxies = new List<proxyObject>();

		// Token: 0x04000022 RID: 34
		public static bool updating = false;

		// Token: 0x04000023 RID: 35
		private static string[] URL = null;

		// Token: 0x04000024 RID: 36
		private static int proxyindex = 0;
	}
}
