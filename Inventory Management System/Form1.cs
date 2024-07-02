using System.ComponentModel;
using System.Linq;

namespace Inventory_Management_System
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			// Configure data grid 1
			Inventory.SelectedPartIndex = -1;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
			dataGridView1.RowHeadersVisible = false;
			dataGridView1.DataSource = Inventory.Parts;

			// Configure data grid 2
			Inventory.SelectedProductIndex = -1;
			dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView2.DefaultCellStyle.SelectionForeColor = dataGridView2.DefaultCellStyle.ForeColor;
			dataGridView2.RowHeadersVisible = false;
			dataGridView2.DataSource = Inventory.Products;

		}

		// Set INDEXES
		private void SetSelectedPartIndex()
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

		private void SetSelectedProductIndex()
		{
			if (dataGridView2.SelectedRows.Count != 0)
			{
				DataGridViewRow row = dataGridView2.SelectedRows[0];
				Inventory.SelectedProductIndex = row.Index;
			}
			else
			{
				Inventory.SelectedProductIndex = -1;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;

			dataGridView1.ClearSelection();
			dataGridView2.ClearSelection();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Inventory.CurrentPart = null;
			Form2 form2 = new Form2();
			form2.Show();
			this.Hide();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			Inventory.CurrentProduct = null;
			Form3 form3 = new Form3();
			form3.Show(); this.Hide();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		// Search for Parts
		private void button1_Click(object sender, EventArgs e)
		{
			BindingList<Part> TempPartList = new BindingList<Part>();
			bool found = false;
			if (textBox1.Text != "")
			{
				for (int i = 0; i < Inventory.Parts.Count; i++)
				{
					if (Inventory.Parts[i].Name.ToUpper().Contains(textBox1.Text.ToUpper()))
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
				MessageBox.Show("No Results Found.");
				dataGridView1.DataSource = Inventory.Parts;
			}
		}

		// Search for Products
		private void button2_Click(object sender, EventArgs e)
		{
			BindingList<Product> TempProductList = new BindingList<Product>();
			bool found = true;
			if (textBox2.Text != "")
			{
				for (int i = 0; i < Inventory.Products.Count; i++)
				{
					if (Inventory.Products[i].Name.ToUpper().Contains(textBox2.Text.ToUpper()))
					{
						TempProductList.Add(Inventory.Products[i]);
						found = true;
					}
				}
				if (found)
				{
					dataGridView2.DataSource = TempProductList;
				}
			}
			if (!found)
			{
				MessageBox.Show("No Results Found");
				dataGridView2.DataSource = Inventory.Products;
			}
		}

		private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			SetSelectedPartIndex();
			dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			SetSelectedProductIndex();
			dataGridView2.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray;
		}

		private void button5_Click(object sender, EventArgs e)
		{
		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			SetSelectedPartIndex();
			if (Inventory.SelectedPartIndex >= 0)
			{
				Inventory.CurrentPart = Inventory.Parts[Inventory.SelectedPartIndex];
				this.Hide();
				Form4 form4 = new Form4();
				form4.Show();
			}
			else
			{
				MessageBox.Show("Please select something to modify.");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			SetSelectedPartIndex();
			if (Inventory.SelectedPartIndex >= 0)
			{
				DialogResult dialogResult = MessageBox.Show("Do you want to delete this part?", "", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					Inventory.Parts.RemoveAt(Inventory.SelectedPartIndex);
				}

			}
			else
			{
				MessageBox.Show("Please select a part to delete");
			}


		}

		private void button8_Click(object sender, EventArgs e)
		{
			SetSelectedProductIndex();
			if (Inventory.SelectedProductIndex >= 0)
			{
				Inventory.CurrentProduct = Inventory.Products[Inventory.SelectedProductIndex];
				this.Hide();
				Form3 form3 = new Form3();
				form3.Show();
			}
			else
			{
				MessageBox.Show("Please select something to modify");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			SetSelectedProductIndex();

			if (Inventory.SelectedProductIndex >= 0)
			{
				Inventory.CurrentProduct = Inventory.Products[Inventory.SelectedProductIndex];
				if (Inventory.CurrentProduct.AssociatedParts.Count == 0)
				{
					DialogResult dialogResult = MessageBox.Show("Do you want to delete this product", "", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						Inventory.Products.RemoveAt(Inventory.SelectedProductIndex);
					}
				}
				else
				{
					MessageBox.Show("Cannot delete product with parts associated.");
				}
			}
			else
			{
				MessageBox.Show("Please select a product to delete");
			}
		}
	}
}
