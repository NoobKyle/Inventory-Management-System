using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
	public partial class Form2 : Form
	{
		private bool isInhouse;
		private Part part;

		// Input Validation
		private bool allowSave()
		{
			if (!ValidateFields.IsNotNullOrWhiteSpace(textBox2.Text)) // Name textbox
			{
				return false;
			}
			if (!ValidateFields.IsDecimal(textBox4.Text)) // Price textbox
			{
				return false;
			}
			if (!ValidateFields.IsInt(textBox3.Text)) // Inventory textbox
			{
				return false;
			}
			if (!ValidateFields.IsInt(textBox6.Text)) // Min textbox
			{
				return false;
			}
			if (!ValidateFields.IsInt(textBox8.Text)) // Max textbox
			{
				return false;
			}
			if (!ValidateFields.InvBetweenMinMax(textBox3.Text, textBox6.Text, textBox8.Text)) // Inventory, min and max
			{
				return false;
			}
			if (isInhouse)
			{
				if (!ValidateFields.IsInt(textBox7.Text)) // Machine id textbox
				{
					return false;
				}
			}
			if (!ValidateFields.IsNotNullOrWhiteSpace(textBox7.Text)) // Machine id textbox
			{
				return false;
			}
			return true;
		}

		public Form2()
		{
			InitializeComponent();
			part = Inventory.CurrentPart;

			if (part != null)
			{
				textBox1.Text = part.PartID.ToString();
				textBox2.Text = part.Name.ToString();
				textBox3.Text = part.InStock.ToString();
				textBox4.Text = part.Price.ToString();
				textBox8.Text = part.Max.ToString();
				textBox6.Text = part.Min.ToString();

				if (Inventory.CurrentPart is Inhouse)
				{
					Inhouse e = (Inhouse)part;
					textBox7.Text = e.MachineID.ToString();
					isInhouse = true;
					radioButton1.Checked = true;
				}
				else
				{
					Outsourced e = (Outsourced)part;
					textBox7.Text = e.CompanyName;
					isInhouse = false;
					radioButton2.Checked = true;
				}
			}
		}

		void CreateNewPart()
		{
			if (isInhouse)
			{
				Inhouse inhousePart = new Inhouse(textBox2.Text, Convert.ToDecimal(textBox4.Text),
					Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text),
					Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox7.Text)
					);
				Inventory.AddPart(inhousePart);
			}
			else
			{
				Outsourced outsourcedPart = new Outsourced(textBox2.Text, Convert.ToDecimal(textBox4.Text),
					Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text),
					Convert.ToInt32(textBox8.Text), textBox7.Text
					);
				Inventory.AddPart(outsourcedPart);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = allowSave();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

			button1.Enabled = allowSave();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			label8.Text = "Machine ID";
			isInhouse = true;

			button1.Enabled = allowSave();
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			label8.Text = "Company Name";
			isInhouse = false;

			button1.Enabled = allowSave();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (part == null)
			{
				CreateNewPart();
			}
			this.Close();
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = allowSave();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = allowSave();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = allowSave();
		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = allowSave();
		}
	}
}
