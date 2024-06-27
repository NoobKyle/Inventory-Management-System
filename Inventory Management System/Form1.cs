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

		private void SetSelectedProductIndex() {
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
			Form2 form2 = new Form2();
			form2.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			label3.Text = Test.MyMethod();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
