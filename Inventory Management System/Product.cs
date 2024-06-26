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

		public void AddAssociatedPart(Part part)
		{
			AssociatedParts.Add(part);
		}

		public bool RemoveAssociatedPart(int PartID)
		{
			var partToRemove = AssociatedParts.Where(p => p.PartID == PartID).FirstOrDefault();
			if (partToRemove == null)
			{
				throw new Exception(message: $"A part with ID #{PartID} is not in this product.");
			}

			AssociatedParts.Remove(partToRemove);
			return true;
		}

		public Part LookupAssociatedPart(int PartID)
		{
			var part = AssociatedParts.Where(p => p.PartID == PartID).FirstOrDefault();
			if (part == null)
			{
				throw new Exception(message: $"A part with ID #{PartID} is not in this product.");
			}

			return part;
		}



	}
}
