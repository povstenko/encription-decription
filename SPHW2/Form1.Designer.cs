namespace SPHW2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.decrypted = new System.Windows.Forms.RichTextBox();
			this.encrypted = new System.Windows.Forms.RichTextBox();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.nudKey = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudKey)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// decrypted
			// 
			this.decrypted.BackColor = System.Drawing.SystemColors.Window;
			this.decrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.decrypted.Location = new System.Drawing.Point(12, 82);
			this.decrypted.Name = "decrypted";
			this.decrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.decrypted.Size = new System.Drawing.Size(317, 358);
			this.decrypted.TabIndex = 2;
			this.decrypted.Text = "";
			this.decrypted.TextChanged += new System.EventHandler(this.button1_Click);
			// 
			// encrypted
			// 
			this.encrypted.BackColor = System.Drawing.SystemColors.Window;
			this.encrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.encrypted.Location = new System.Drawing.Point(429, 82);
			this.encrypted.Name = "encrypted";
			this.encrypted.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.encrypted.Size = new System.Drawing.Size(317, 357);
			this.encrypted.TabIndex = 3;
			this.encrypted.Text = "";
			this.encrypted.TextChanged += new System.EventHandler(this.button2_Click);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEncrypt.Location = new System.Drawing.Point(339, 216);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(84, 23);
			this.btnEncrypt.TabIndex = 4;
			this.btnEncrypt.Text = "Encrypt ->";
			this.btnEncrypt.UseVisualStyleBackColor = false;
			this.btnEncrypt.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDecrypt.Location = new System.Drawing.Point(339, 245);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(84, 23);
			this.btnDecrypt.TabIndex = 5;
			this.btnDecrypt.Text = "<- Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.button2_Click);
			// 
			// nudKey
			// 
			this.nudKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.nudKey.Location = new System.Drawing.Point(543, 7);
			this.nudKey.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudKey.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.nudKey.Name = "nudKey";
			this.nudKey.Size = new System.Drawing.Size(71, 20);
			this.nudKey.TabIndex = 6;
			this.nudKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudKey.Value = new decimal(new int[] {
            179326,
            0,
            0,
            0});
			this.nudKey.ValueChanged += new System.EventHandler(this.nudKey_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(457, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Encryption Key:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "File Path:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(69, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(382, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "D:\\encrypt.txt";
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(15, 33);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(731, 22);
			this.progressBar1.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(621, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 13;
			this.label3.Text = "Block Size:";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.numericUpDown1.Location = new System.Drawing.Point(687, 7);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(59, 20);
			this.numericUpDown1.TabIndex = 12;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numericUpDown1.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.progressBar1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numericUpDown1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(758, 68);
			this.panel1.TabIndex = 14;
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(339, 82);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(84, 23);
			this.btnLoad.TabIndex = 15;
			this.btnLoad.Text = "Load File";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnLoad;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(758, 452);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudKey);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.encrypted);
			this.Controls.Add(this.decrypted);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Encrypt / Decrypt";
			((System.ComponentModel.ISupportInitialize)(this.nudKey)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox decrypted;
		private System.Windows.Forms.RichTextBox encrypted;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.NumericUpDown nudKey;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLoad;
	}
}

