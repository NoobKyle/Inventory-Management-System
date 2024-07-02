namespace Inventory_Management_System
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			radioButton1 = new RadioButton();
			radioButton2 = new RadioButton();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			textBox8 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(93, 30);
			label1.TabIndex = 0;
			label1.Text = "Add Part";
			label1.Click += label1_Click;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Location = new Point(172, 19);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(74, 19);
			radioButton1.TabIndex = 1;
			radioButton1.TabStop = true;
			radioButton1.Text = "In-House";
			radioButton1.UseVisualStyleBackColor = true;
			radioButton1.CheckedChanged += radioButton1_CheckedChanged;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(337, 19);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(87, 19);
			radioButton2.TabIndex = 2;
			radioButton2.TabStop = true;
			radioButton2.Text = "Outsourced";
			radioButton2.UseVisualStyleBackColor = true;
			radioButton2.CheckedChanged += radioButton2_CheckedChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(172, 92);
			label2.Name = "label2";
			label2.Size = new Size(29, 21);
			label2.TabIndex = 3;
			label2.Text = "ID ";
			label2.Click += label2_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(149, 138);
			label3.Name = "label3";
			label3.Size = new Size(52, 21);
			label3.TabIndex = 4;
			label3.Text = "Name";
			label3.Click += label3_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(125, 184);
			label4.Name = "label4";
			label4.Size = new Size(76, 21);
			label4.TabIndex = 5;
			label4.Text = "Inventory";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F);
			label5.Location = new Point(112, 236);
			label5.Name = "label5";
			label5.Size = new Size(89, 21);
			label5.TabIndex = 6;
			label5.Text = "Price / Cost";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.Location = new Point(162, 298);
			label6.Name = "label6";
			label6.Size = new Size(39, 21);
			label6.TabIndex = 7;
			label6.Text = "Max";
			label6.Click += label6_Click;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F);
			label7.Location = new Point(368, 302);
			label7.Name = "label7";
			label7.Size = new Size(37, 21);
			label7.TabIndex = 8;
			label7.Text = "Min";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F);
			label8.Location = new Point(113, 381);
			label8.Name = "label8";
			label8.Size = new Size(88, 21);
			label8.TabIndex = 9;
			label8.Text = "Machine ID";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(237, 90);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(208, 23);
			textBox1.TabIndex = 10;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(237, 136);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(208, 23);
			textBox2.TabIndex = 11;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(237, 182);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(208, 23);
			textBox3.TabIndex = 12;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(237, 236);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(208, 23);
			textBox4.TabIndex = 13;
			textBox4.TextChanged += textBox4_TextChanged;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(435, 296);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(113, 23);
			textBox6.TabIndex = 15;
			textBox6.TextChanged += textBox6_TextChanged;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(237, 379);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(215, 23);
			textBox7.TabIndex = 16;
			textBox7.TextChanged += textBox7_TextChanged;
			// 
			// textBox8
			// 
			textBox8.Location = new Point(237, 296);
			textBox8.Name = "textBox8";
			textBox8.Size = new Size(113, 23);
			textBox8.TabIndex = 17;
			textBox8.TextChanged += textBox8_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(337, 460);
			button1.Name = "button1";
			button1.Size = new Size(94, 57);
			button1.TabIndex = 18;
			button1.Text = "Save";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(456, 460);
			button2.Name = "button2";
			button2.Size = new Size(92, 57);
			button2.TabIndex = 19;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(593, 551);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox8);
			Controls.Add(textBox7);
			Controls.Add(textBox6);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(radioButton2);
			Controls.Add(radioButton1);
			Controls.Add(label1);
			Name = "Form2";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Form2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox6;
		private TextBox textBox7;
		private TextBox textBox8;
		private Button button1;
		private Button button2;
	}
}