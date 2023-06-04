using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApp1
{
	// Token: 0x0200000C RID: 12
	internal class OpenFile
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000399C File Offset: 0x00001B9C
		public static string[] openFile(object title)
		{
			string[] a = null;
			try
			{
				Thread thread = new Thread(delegate()
				{
					OpenFileDialog openFileDialog = new OpenFileDialog();
					openFileDialog.Title = title.ToString();
					openFileDialog.Multiselect = false;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						a = File.ReadAllLines(openFileDialog.FileName);
					}
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				thread.Join();
			}
			catch (Exception)
			{
				return null;
			}
			return a;
		}
	}
}
