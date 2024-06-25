using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	public class Product
	{
		public BindingList<Part> AssociatedParts = new BindingList<Part>();
		public int ProductID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int InStock { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }

		public static int count = 1;

		public Product(string text, decimal v2, int v3, int v4, int v5)
		{
			ProductID = count++;
			Name = text;
			Price = v2;
			InStock = v3;
			Min = v4;
			Max = v5;
		}

		public Product() 
		{
			ProductID = -1;
			Name = "name";
			Price = 0;
			InStock = 0;
			Min = 0;
			Max = 0;
		}


	}
}
