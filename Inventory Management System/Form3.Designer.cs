namespace Inventory_Management_System
{
	partial class Form3
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			textBox7 = new TextBox();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(24, 26);
			label1.Name = "label1";
			label1.Size = new Size(129, 30);
			label1.TabIndex = 0;
			label1.Text = "Add Product";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(24, 177);
			label2.Name = "label2";
			label2.Size = new Size(25, 21);
			label2.TabIndex = 1;
			label2.Text = "ID";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(24, 218);
			label3.Name = "label3";
			label3.Size = new Size(52, 21);
			label3.TabIndex = 2;
			label3.Text = "Name";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(24, 262);
			label4.Name = "label4";
			label4.Size = new Size(76, 21);
			label4.TabIndex = 3;
			label4.Text = "Inventory";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 12F);
			label5.Location = new Point(24, 306);
			label5.Name = "label5";
			label5.Size = new Size(44, 21);
			label5.TabIndex = 4;
			label5.Text = "Price";
			label5.Click += label5_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 12F);
			label6.Location = new Point(24, 350);
			label6.Name = "label6";
			label6.Size = new Size(39, 21);
			label6.TabIndex = 5;
			label6.Text = "Max";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 12F);
			label7.Location = new Point(193, 350);
			label7.Name = "label7";
			label7.Size = new Size(37, 21);
			label7.TabIndex = 6;
			label7.Text = "Min";
			label7.Click += label7_Click;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 12F);
			label8.Location = new Point(395, 87);
			label8.Name = "label8";
			label8.Size = new Size(140, 21);
			label8.TabIndex = 7;
			label8.Text = "All Candidate Parts";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 12F);
			label9.Location = new Point(393, 368);
			label9.Name = "label9";
			label9.Size = new Size(243, 21);
			label9.TabIndex = 8;
			label9.Text = "Parts Associated with this Product";
			label9.Click += label9_Click;
			// 
			// button1
			// 
			button1.Location = new Point(655, 86);
			button1.Name = "button1";
			button1.Size = new Size(85, 27);
			button1.TabIndex = 9;
			button1.Text = "Search";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(941, 335);
			button2.Name = "button2";
			button2.Size = new Size(75, 36);
			button2.TabIndex = 12;
			button2.Text = "Add";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(941, 609);
			button3.Name = "button3";
			button3.Size = new Size(75, 33);
			button3.TabIndex = 13;
			button3.Text = "Delete";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(831, 648);
			button4.Name = "button4";
			button4.Size = new Size(75, 37);
			button4.TabIndex = 14;
			button4.Text = "Save";
			button4.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			button5.Location = new Point(941, 648);
			button5.Name = "button5";
			button5.Size = new Size(75, 37);
			button5.TabIndex = 15;
			button5.Text = "Cancel";
			button5.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(115, 179);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 23);
			textBox1.TabIndex = 16;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(115, 220);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(211, 23);
			textBox2.TabIndex = 17;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(115, 264);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(211, 23);
			textBox3.TabIndex = 18;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(115, 308);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(211, 23);
			textBox4.TabIndex = 19;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(69, 352);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(107, 23);
			textBox5.TabIndex = 20;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(236, 352);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(110, 23);
			textBox6.TabIndex = 21;
			textBox6.TextChanged += textBox6_TextChanged;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(755, 89);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(211, 23);
			textBox7.TabIndex = 22;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.Window;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(393, 118);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(645, 211);
			dataGridView1.TabIndex = 23;
			// 
			// dataGridView2
			// 
			dataGridView2.BackgroundColor = SystemColors.Window;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(393, 392);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(645, 211);
			dataGridView2.TabIndex = 24;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1063, 707);
			Controls.Add(dataGridView2);
			Controls.Add(dataGridView1);
			Controls.Add(textBox7);
			Controls.Add(textBox6);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form3";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Form3";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
		private Button button5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox7;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
	}
}