using System;

namespace ConsoleApp1
{
	// Token: 0x0200000F RID: 15
	public class proxyObject
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000022B5 File Offset: 0x000004B5
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000022BD File Offset: 0x000004BD
		public string Proxy { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000022C6 File Offset: 0x000004C6
		// (set) Token: 0x06000037 RID: 55 RVA: 0x000022CE File Offset: 0x000004CE
		public bool Working { get; set; }

		// Token: 0x06000038 RID: 56 RVA: 0x000022D7 File Offset: 0x000004D7
		public proxyObject(string proxy, bool working)
		{
			this.Proxy = proxy;
			this.Working = working;
		}
	}
}
