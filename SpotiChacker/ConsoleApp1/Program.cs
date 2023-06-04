using System;
using System.IO;
using System.Threading;
using Figgle;

namespace ConsoleApp1
{
	// Token: 0x0200000E RID: 14
	internal class Program
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00003A48 File Offset: 0x00001C48
		private static void Main(string[] args)
		{
			DiscordRPC.Initialize();
			Console.Title = "Orkun's Spoti Chacker";
			Console.WriteLine(Program.logo);
			for (;;)
			{
				int num = ChooseModule.choose();
				if (num == 2)
				{
					Config.renewconfig(false);
				}
				else if (num == 1)
				{
					break;
				}
			}
			string str = DateTime.UtcNow.ToString().Replace("/", "-").Replace("/", "-").Replace("/", "-").Replace("/", "-").Replace(":", "-").Replace(":", "-").Replace(":", "-").Replace(":", "-");
			Program.outFolder = "results\\" + str;
			Directory.CreateDirectory(Program.outFolder);
			Directory.CreateDirectory(Program.outFolder + "\\country\\free");
			Directory.CreateDirectory(Program.outFolder + "\\country\\premium");
			CUI.Init();
			new Thread(new ThreadStart(Module1.checkercui)).Start();
			Thread.Sleep(100000);
		}

		// Token: 0x0400001D RID: 29
		public static string logo = FiggleFonts.Standard.Render("                           Orkun!", null);

		// Token: 0x0400001E RID: 30
		public static string outFolder = null;
	}
}
