using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		// Mouse Hareketini algılamak için
		bool mouseDown;
		private Point offset;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			// atamalar ve convert
			Double say1 = 1, say2 = 1, sonuc;
			say1 = Convert.ToDouble(textBox1.Text);
			say2 = Convert.ToDouble(textBox2.Text);

			// Toplama rb1
			if (radioButton1.Checked == true)
			{
				sonuc = say1 + say2;
				MessageBox.Show("= " + sonuc, "İşleminizin Sonucu",
				MessageBoxButtons.OK);
				label1.Text = Convert.ToString("Sonuç : " + sonuc);
			}

			// çıkarma rb2
			if (radioButton2.Checked == true)
			{
				sonuc = say1 - say2;
				MessageBox.Show("= " + sonuc, "İşleminizin Sonucu",
				MessageBoxButtons.OK);
				label1.Text = Convert.ToString("Sonuç : " + sonuc);
			}

			// çarpma rb3
			if (radioButton3.Checked == true)
			{
				sonuc = say1 * say2;
				MessageBox.Show("= " + sonuc, "İşleminizin Sonucu",
				MessageBoxButtons.OK);
				label1.Text = Convert.ToString("Sonuç : " + sonuc);
			}

			// bölme rb4
			if (radioButton4.Checked == true)
			{
				sonuc = say1 / say2;
				MessageBox.Show("= "+sonuc , "İşleminizin Sonucu",
				MessageBoxButtons.OK);
				label1.Text = Convert.ToString("Sonuç : "+sonuc);
			}


		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void mouseDown_Event(object sender, MouseEventArgs e)
		{
			// Formu taşıyabilmek için
			offset.X = e.X;
			offset.Y = e.Y;
			mouseDown = true;
		}

		private void MouseMove_Event(object sender, MouseEventArgs e)
		{
			if (mouseDown == true)
			{
				Point currentScreePos = PointToScreen(e.Location);
				Location = new Point(currentScreePos.X - offset.X, currentScreePos.Y - offset.Y);
			}
		}

		private void MouseUp_Event(object sender, MouseEventArgs e)
		{
			mouseDown = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Exit butonu
			Application.Exit();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Minimize butonu
			this.WindowState = FormWindowState.Minimized;
		}
	}
}
