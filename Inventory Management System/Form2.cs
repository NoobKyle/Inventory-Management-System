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

		// Checks Go Here

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

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

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
			Form3 form3 = new Form3();
			form3.Show();
		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{
			//button1.Enabled = allowSave;
		}
	}
}
