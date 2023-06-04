using System;
using System.IO;
using Leaf.xNet;
using Newtonsoft.Json.Linq;
using ProtoBuf;

namespace ConsoleApp1
{
	// Token: 0x02000011 RID: 17
	internal class puff
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00003D04 File Offset: 0x00001F04
		public static string getCapture(string username, string key, string proxy)
		{
			string result;
			try
			{
				puff.main main = new puff.main();
				puff.one one = new puff.one();
				puff.two two = new puff.two();
				one.Line1 = "65b708073fc0480ea92a077233ca87bd";
				one.Line2 = "S-1-5-21-3906878023-3586315189-2161068791";
				two.Line1 = username;
				two.Line2 = key;
				main.one = one;
				main.two = two;
				MemoryStream memoryStream = new MemoryStream();
				Serializer.Serialize<puff.main>(memoryStream, main);
				HttpRequest httpRequest = new HttpRequest();
				puff.Responsemain responsemain = Serializer.Deserialize<puff.Responsemain>(new MemoryStream(httpRequest.Post("https://login5.spotify.com/v3/login", memoryStream.ToArray(), "application/x-protobuf").ToBytes()));
				httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3000.145 Safari/537.36";
				httpRequest.Post("https://www.spotify.com/token-bounce/?url=/redirect/account-page", "oauth_token=" + responsemain.one.Line2, "application/x-www-form-urlencoded");
				result = JObject.Parse(httpRequest.Get("https://www.spotify.com/us/home-hub/api/v1/family/home/", null).ToString()).ToString();
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x02000012 RID: 18
		[ProtoContract]
		private class Responsemain
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002329 File Offset: 0x00000529
			// (set) Token: 0x06000041 RID: 65 RVA: 0x00002331 File Offset: 0x00000531
			[ProtoMember(1)]
			public puff.response one { get; set; }
		}

		// Token: 0x02000013 RID: 19
		[ProtoContract]
		private class response
		{
			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000043 RID: 67 RVA: 0x0000233A File Offset: 0x0000053A
			// (set) Token: 0x06000044 RID: 68 RVA: 0x00002342 File Offset: 0x00000542
			[ProtoMember(1)]
			public string Line1 { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000045 RID: 69 RVA: 0x0000234B File Offset: 0x0000054B
			// (set) Token: 0x06000046 RID: 70 RVA: 0x00002353 File Offset: 0x00000553
			[ProtoMember(2)]
			public string Line2 { get; set; }

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000047 RID: 71 RVA: 0x0000235C File Offset: 0x0000055C
			// (set) Token: 0x06000048 RID: 72 RVA: 0x00002364 File Offset: 0x00000564
			[ProtoMember(3)]
			public string Line3 { get; set; }
		}

		// Token: 0x02000014 RID: 20
		[ProtoContract]
		private class main
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600004A RID: 74 RVA: 0x0000236D File Offset: 0x0000056D
			// (set) Token: 0x0600004B RID: 75 RVA: 0x00002375 File Offset: 0x00000575
			[ProtoMember(1)]
			public puff.one one { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600004C RID: 76 RVA: 0x0000237E File Offset: 0x0000057E
			// (set) Token: 0x0600004D RID: 77 RVA: 0x00002386 File Offset: 0x00000586
			[ProtoMember(100)]
			public puff.two two { get; set; }
		}

		// Token: 0x02000015 RID: 21
		[ProtoContract]
		private class one
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600004F RID: 79 RVA: 0x0000238F File Offset: 0x0000058F
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00002397 File Offset: 0x00000597
			[ProtoMember(1)]
			public string Line1 { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000051 RID: 81 RVA: 0x000023A0 File Offset: 0x000005A0
			// (set) Token: 0x06000052 RID: 82 RVA: 0x000023A8 File Offset: 0x000005A8
			[ProtoMember(2)]
			public string Line2 { get; set; }
		}

		// Token: 0x02000016 RID: 22
		[ProtoContract]
		private class two
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000054 RID: 84 RVA: 0x000023B1 File Offset: 0x000005B1
			// (set) Token: 0x06000055 RID: 85 RVA: 0x000023B9 File Offset: 0x000005B9
			[ProtoMember(1)]
			public string Line1 { get; set; }

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000056 RID: 86 RVA: 0x000023C2 File Offset: 0x000005C2
			// (set) Token: 0x06000057 RID: 87 RVA: 0x000023CA File Offset: 0x000005CA
			[ProtoMember(2)]
			public string Line2 { get; set; }
		}
	}
}
