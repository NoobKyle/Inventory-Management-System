﻿namespace Inventory_Management_System
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			button1 = new Button();
			textBox1 = new TextBox();
			button2 = new Button();
			textBox2 = new TextBox();
			button3 = new Button();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			button8 = new Button();
			button9 = new Button();
			dataGridView1 = new DataGridView();
			dataGridView2 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(383, 37);
			label1.TabIndex = 0;
			label1.Text = "Inventory Management System";
			label1.Click += label1_Click_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label2.Location = new Point(30, 112);
			label2.Name = "label2";
			label2.Size = new Size(53, 25);
			label2.TabIndex = 1;
			label2.Text = "Parts";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.Location = new Point(512, 112);
			label3.Name = "label3";
			label3.Size = new Size(86, 25);
			label3.TabIndex = 2;
			label3.Text = "Products";
			label3.Click += label3_Click;
			// 
			// button1
			// 
			button1.Location = new Point(205, 115);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 3;
			button1.Text = "Search";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(286, 113);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(215, 23);
			textBox1.TabIndex = 4;
			textBox1.TextChanged += textBox1_TextChanged_1;
			// 
			// button2
			// 
			button2.Location = new Point(681, 116);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 5;
			button2.Text = "Search";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(762, 116);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(210, 23);
			textBox2.TabIndex = 6;
			// 
			// button3
			// 
			button3.Location = new Point(903, 559);
			button3.Name = "button3";
			button3.Size = new Size(69, 29);
			button3.TabIndex = 7;
			button3.Text = "Exit";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(316, 525);
			button4.Name = "button4";
			button4.Size = new Size(63, 28);
			button4.TabIndex = 10;
			button4.Text = "Add";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Location = new Point(385, 525);
			button5.Name = "button5";
			button5.Size = new Size(55, 28);
			button5.TabIndex = 11;
			button5.Text = "Modify";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click_1;
			// 
			// button6
			// 
			button6.Location = new Point(446, 525);
			button6.Name = "button6";
			button6.Size = new Size(55, 28);
			button6.TabIndex = 12;
			button6.Text = "Delete";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// button7
			// 
			button7.Location = new Point(917, 525);
			button7.Name = "button7";
			button7.Size = new Size(55, 28);
			button7.TabIndex = 13;
			button7.Text = "Delete";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Location = new Point(856, 525);
			button8.Name = "button8";
			button8.Size = new Size(55, 28);
			button8.TabIndex = 14;
			button8.Text = "Modify";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button9
			// 
			button9.Location = new Point(795, 525);
			button9.Name = "button9";
			button9.Size = new Size(55, 28);
			button9.TabIndex = 15;
			button9.Text = "Add";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.BackgroundColor = SystemColors.Window;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 150);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.Size = new Size(489, 369);
			dataGridView1.TabIndex = 16;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
			// 
			// dataGridView2
			// 
			dataGridView2.BackgroundColor = SystemColors.Window;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(512, 150);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.Size = new Size(476, 369);
			dataGridView2.TabIndex = 17;
			dataGridView2.CellContentClick += dataGridView2_CellContentClick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1000, 600);
			Controls.Add(dataGridView2);
			Controls.Add(dataGridView1);
			Controls.Add(button9);
			Controls.Add(button8);
			Controls.Add(button7);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Inventory Management System";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button button1;
		private TextBox textBox1;
		private Button button2;
		private TextBox textBox2;
		private Button button3;
		private Button button4;
		private Button button5;
		private Button button6;
		private Button button7;
		private Button button8;
		private Button button9;
		private DataGridView dataGridView1;
		private DataGridView dataGridView2;
	}
}
