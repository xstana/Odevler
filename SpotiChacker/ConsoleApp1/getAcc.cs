using System;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApp1
{
	// Token: 0x0200000A RID: 10
	internal class getAcc
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000036C4 File Offset: 0x000018C4
		public static string getacc()
		{
			string result;
			try
			{
				int index = getAcc.accindex;
				getAcc.accindex++;
				result = Stats.combo[index];
			}
			catch (Exception)
			{
				Thread.Sleep(2000);
				Application.Exit();
				result = null;
			}
			return result;
		}

		// Token: 0x04000018 RID: 24
		public static bool a;

		// Token: 0x04000019 RID: 25
		public static int accindex;

		// Token: 0x0400001A RID: 26
		public static bool lellll;
	}
}
