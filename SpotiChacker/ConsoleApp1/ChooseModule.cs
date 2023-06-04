using System;
using System.Diagnostics;
using System.Drawing;
using Colorful;

namespace ConsoleApp1
{
	// Token: 0x02000004 RID: 4
	internal class ChooseModule
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002C98 File Offset: 0x00000E98
		public static int choose()
		{
			Colorful.Console.Clear();
			Colorful.Console.WriteLine(Program.logo);
			Colorful.Console.WriteLine("");
			Colorful.Console.WriteLine("Modül seç ", Color.DodgerBlue);
			Colorful.Console.WriteLine("[1] Heap Checker");
			Colorful.Console.WriteLine("[2] Config Ayarları");
			Colorful.Console.WriteLine("[3] Kahve ısmarla (rakı balıkta olur)!");
			int keyChar;
			for (;;)
			{
				keyChar = (int)Colorful.Console.ReadKey().KeyChar;
				Colorful.Console.Write("\b \b");
				if (keyChar == 51)
				{
					Process.Start("https://www.bynogame.com/tr/destekle/xstana");
				}
				else if (keyChar == 49 || keyChar == 50)
				{
					break;
				}
			}
			if (keyChar == 49)
			{
				return 1;
			}
			if (keyChar != 50)
			{
				return 0;
			}
			return 2;
		}
	}
}
