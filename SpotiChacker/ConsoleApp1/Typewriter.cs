using System;
using System.Threading;

namespace ConsoleApp1
{
	// Token: 0x02000019 RID: 25
	internal class Typewriter
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00003E54 File Offset: 0x00002054
		public static void Typewrite(string message)
		{
			for (int i = 0; i < message.Length; i++)
			{
				Console.Write(message[i]);
				Thread.Sleep(60);
			}
		}
	}
}
