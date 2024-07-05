using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_System
{
	public partial class Form5 : Form
	{
		// Variables
		private Product product;
		private BindingList<Part> tempList;

		// Validation checks
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
			if (!ValidateFields.IsInt(textBox5.Text)) // Max textbox
			{
				return false;
			}
			if (!ValidateFields.InvBetweenMinMax(textBox3.Text, textBox6.Text, textBox5.Text)) // Inventory, min and max
			{
				return false;
			}
			return true;
		}



		public Form5()
		{
			InitializeComponent();

			product = Inventory.CurrentProduct;

			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.DataSource = Inventory.Parts;

			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;
			dataGridView2.RowHeadersVisible = false;


			if (product != null)
			{
				textBox1.Text = product.ProductID.ToString();
				textBox2.Text = product.Name.ToString();
				textBox4.Text = product.Price.ToString();
				textBox3.Text = product.InStock.ToString();
				textBox6.Text = product.Min.ToString();
				textBox5.Text = product.Max.ToString();

				for (int i = 0; i < product.AssociatedParts.Count; i++)
				{
					Part productpart = product.AssociatedParts[i];

					for (int j = 0; j < Inventory.Parts.Count; j++)
					{
						Part part = Inventory.Parts[j];
						Inventory.ReplacePart(part, productpart);
					}
				}

				tempList = new BindingList<Part>();
				for (int i = 0; i < product.AssociatedParts.Count; i++)
				{
					tempList.Add(product.AssociatedParts[i]);
				}
			}
			else
			{
				product = new Product();
				product.AssociatedParts = new BindingList<Part>();
			}


			dataGridView2.DataSource = product.AssociatedParts;
		}

		private void SetdataGridView1Index()
		{
			if (dataGridView1.SelectedRows.Count != 0)
			{
				DataGridViewRow row = this.dataGridView1.SelectedRows[0];
				Inventory.SelectedPartIndex = row.Index;
			}
			else
			{
				Inventory.SelectedPartIndex = -1;
			}
		}

		private void SetdataGridView2Index()
		{
			if (dataGridView2.SelectedRows.Count != 0)
			{
				DataGridViewRow row = this.dataGridView2.SelectedRows[0];
				Inventory.SelectedPartIndex = row.Index;
			}
			else
			{
				Inventory.SelectedPartIndex = -1;
			}
		}


		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			SetdataGridView2Index();
			if (Inventory.SelectedPartIndex >= 0)
			{
				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					product.AssociatedParts.RemoveAt(Inventory.SelectedPartIndex);
				}
			}
			else
			{
				MessageBox.Show("Please select a part to delete");
			}
			button4.Enabled = allowSave();
		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{
			button4.Enabled = allowSave();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			BindingList<Part> TempPartList = new BindingList<Part>();
			bool found = false;

			if (textBox7.Text != "")
			{
				for (int i = 0; i < Inventory.Parts.Count; i++)
				{
					if (Inventory.Parts[i].Name.ToUpper().Contains(textBox7.Text.ToUpper()))
					{
						TempPartList.Add(Inventory.Parts[i]);
						found = true;
					}
				}
				if (found)
				{
					dataGridView1.DataSource = TempPartList;
				}
			}
			if (!found)
			{
				MessageBox.Show("No Results Foung");
				dataGridView1.DataSource = Inventory.Parts;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (product.ProductID == -1)
			{
				CreateNewProduct();
			}
			else
			{
				modifyProduct();
			}
			this.Close();
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}

		// Create a New Product
		void CreateNewProduct()
		{
			Product newProduct = new Product(textBox2.Text, Convert.ToDecimal(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox5.Text));

			Inventory.AddProduct(newProduct);
			newProduct.AssociatedParts = product.AssociatedParts;
		}
		// Modify Product
		private void modifyProduct()
		{
			product.Name = textBox2.Text;
			product.Price = Convert.ToDecimal(textBox4.Text);
			product.InStock = Convert.ToInt32(textBox3.Text);
			product.Min = Convert.ToInt32(textBox6.Text);
			product.Max = Convert.ToInt32(textBox5.Text);
		}



		private void Form3_Load(object sender, EventArgs e)
		{
			DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;

			// Use clear selection
			dataGridView1.ClearSelection();
			dataGridView2.ClearSelection();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SetdataGridView1Index();
			dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			SetdataGridView1Index();
			if (Inventory.SelectedPartIndex >= 0)
			{
				Inventory.CurrentPart = Inventory.Parts[Inventory.SelectedPartIndex];
				product.AssociatedParts.Add(Inventory.CurrentPart);
			}
			else
			{
				MessageBox.Show("Please select a part to add");
			}
			button4.Enabled = allowSave();
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SetdataGridView2Index();
			dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{
			button4.Enabled = allowSave();
		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{
			button4.Enabled = allowSave();
		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			button4.Enabled = allowSave();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{
			button4.Enabled = allowSave();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			product.AssociatedParts = tempList;
			this.Close();
			this.Hide();
			Form1 form1 = new Form1();
			form1.Show();
		}
	}
}
