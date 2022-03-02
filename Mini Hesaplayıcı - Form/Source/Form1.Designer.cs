
namespace WindowsFormsApp2
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Desktop;
			this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textBox1.Location = new System.Drawing.Point(208, 134);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(289, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.Black;
			this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.textBox2.Location = new System.Drawing.Point(208, 223);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(289, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.BackColor = System.Drawing.Color.Transparent;
			this.radioButton1.Location = new System.Drawing.Point(160, 376);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(14, 13);
			this.radioButton1.TabIndex = 5;
			this.radioButton1.TabStop = true;
			this.radioButton1.UseVisualStyleBackColor = false;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.BackColor = System.Drawing.Color.Transparent;
			this.radioButton2.Location = new System.Drawing.Point(264, 376);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(14, 13);
			this.radioButton2.TabIndex = 6;
			this.radioButton2.TabStop = true;
			this.radioButton2.UseVisualStyleBackColor = false;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.BackColor = System.Drawing.Color.Transparent;
			this.radioButton3.Location = new System.Drawing.Point(369, 376);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(14, 13);
			this.radioButton3.TabIndex = 7;
			this.radioButton3.TabStop = true;
			this.radioButton3.UseVisualStyleBackColor = false;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.BackColor = System.Drawing.Color.Transparent;
			this.radioButton4.Location = new System.Drawing.Point(460, 376);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(14, 13);
			this.radioButton4.TabIndex = 8;
			this.radioButton4.TabStop = true;
			this.radioButton4.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(248, 273);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 40);
			this.button1.TabIndex = 9;
			this.button1.Text = " ";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label1.Location = new System.Drawing.Point(322, 316);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = " ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 28);
			this.panel1.TabIndex = 11;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
			this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.ForeColor = System.Drawing.Color.Transparent;
			this.button2.Location = new System.Drawing.Point(10, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(18, 21);
			this.button2.TabIndex = 0;
			this.button2.Text = " ";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(-15, -13);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 0;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.ForeColor = System.Drawing.Color.Transparent;
			this.button3.Location = new System.Drawing.Point(34, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 22);
			this.button3.TabIndex = 1;
			this.button3.Text = " ";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(720, 480);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(720, 480);
			this.MinimumSize = new System.Drawing.Size(720, 480);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sayı Hesaplayıcı";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button3;
	}
}

