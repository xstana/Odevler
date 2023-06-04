using System;
using System.Drawing;
using System.IO;
using System.Threading;
using Colorful;
using Newtonsoft.Json;

namespace ConsoleApp1
{
	// Token: 0x0200000B RID: 11
	internal class Module1
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003718 File Offset: 0x00001918
		public static void checkercui()
		{
			Colorful.Console.Clear();
			Colorful.Console.WriteLine(Program.logo);
			Colorful.Console.WriteLine("");
			Colorful.Console.ForegroundColor = Color.LightGray;
			Colorful.Console.WriteLine("başlanıyor . . .", Color.LightGray);
			Thread.Sleep(3000);
			for (;;)
			{
				Colorful.Console.Clear();
				Colorful.Console.WriteLine(Program.logo);
				Colorful.Console.WriteLine("");
				Colorful.Console.WriteLine("threadlar aktif : " + Stats.runningThreads.ToString());
				Colorful.Console.WriteLine("");
				Colorful.Console.Write("Çalışan: ");
				Colorful.Console.WriteLine(Stats.DUO + Stats.FREE + Stats.FAMILY_MEMBER + Stats.FAMILY_OWNER + Stats.HULU + Stats.OTHER + Stats.STUDENT, Color.LawnGreen);
				Colorful.Console.Write("Çöp: ");
				Colorful.Console.WriteLine(Stats.INVALID, Color.DarkRed);
				Colorful.Console.Write("Free : ");
				Colorful.Console.WriteLine(Stats.FREE, Color.BurlyWood);
				Colorful.Console.WriteLine("");
				Colorful.Console.Write("Premium : ");
				Colorful.Console.WriteLine(Stats.PREMIUM, Color.LimeGreen);
				Colorful.Console.Write("    Spotify Duo : ");
				Colorful.Console.WriteLine(Stats.DUO, Color.SeaGreen);
				Colorful.Console.Write("    Spotify Öğrenci gariban : ");
				Colorful.Console.WriteLine(Stats.STUDENT, Color.SeaGreen);
				Colorful.Console.Write("    Spotify Hulu : ");
				Colorful.Console.WriteLine(Stats.STUDENT, Color.SeaGreen);
				Colorful.Console.Write("    Spotify Diğer : ");
				Colorful.Console.WriteLine(Stats.OTHER, Color.SeaGreen);
				Colorful.Console.WriteLine("");
				Colorful.Console.Write("Premium Family : ");
				Colorful.Console.WriteLine(Stats.FAMILY_OWNER + Stats.FAMILY_MEMBER, Color.DarkOrchid);
				Colorful.Console.Write("    Aile üye : ");
				Colorful.Console.WriteLine(Stats.FAMILY_MEMBER, Color.Coral);
				Colorful.Console.Write("    Aile ahibi : ");
				Colorful.Console.WriteLine(Stats.FAMILY_OWNER, Color.DeepSkyBlue);
				Colorful.Console.WriteLine("");
				Colorful.Console.Write("Hata : ");
				Colorful.Console.WriteLine(Stats.ERROR, Color.DarkGray);
				Colorful.Console.Write("Kalan : ");
				Colorful.Console.WriteLine(getAcc.accindex.ToString() + "/" + Stats.combo.Count.ToString(), Color.Cornsilk);
				Colorful.Console.Write("Ortalama CPM : ");
				Colorful.Console.WriteLine("1337420", Color.DarkSalmon);
				Colorful.Console.WriteLine("");
				Colorful.Console.ForegroundColor = Color.Goldenrod;
				Typewriter.Typewrite(" Sadece eğitim içindir itliğe kullanmayınız :)");
				Colorful.Console.ForegroundColor = Color.LightGray;
				Thread.Sleep(1500);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002291 File Offset: 0x00000491
		public static Config.configObject getConfig()
		{
			if (File.Exists("config.json"))
			{
				return JsonConvert.DeserializeObject<Config.configObject>(File.ReadAllText("config.json"));
			}
			return Config.renewconfig(true);
		}
	}
}
