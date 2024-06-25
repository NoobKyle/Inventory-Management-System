using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	public class Inventory
	{
		// Properties
		public static BindingList<Product> Products = new BindingList<Product>();
		public static BindingList<Part> Parts = new BindingList<Part>();

		public static Part CurrentPart { get; set; }
		public static int CurrentPartID { get; set; }
		public static int SelectedPartIndex { get; set; }


		public static Product CurrentProduct { get; set; }
		public static int CurrentProductID { get; set; }
		public static int SelectedProductIndex { get; set; }

		// Helper function
		internal static void Swap(Part Part) {
			Parts.Insert(SelectedPartIndex, Part);
			Parts.RemoveAt(SelectedPartIndex + 1);
		}

		// Product Methods

		// add new product
		public static void AddProduct(Product Product)
		{
			Products.Add(Product);
		}

		// remove product from list
		public static bool RemoveProduct(int ProductID)
		{
			bool checkk = false;
			foreach (Product p in Products)
			{
				if (p.ProductID == ProductID)
				{
					Products.Remove(p);
					checkk = true;
				}
				else
				{
					MessageBox.Show("Product does not exist");
					checkk |= false;
				}
			}
			return checkk;
		}

		// lookup a product
		public static Product LookupProduct(int ProductID)
		{
			foreach (Product p in Products)
			{
				if (p.ProductID == ProductID)
				{
					return p;
				}
			}
			return null;
		}

		// update product
		public static void UpdateProduct(int SelectedProductIndex, Product CurrentProduct)
		{
			Products.Insert(SelectedProductIndex, CurrentProduct);
			Products.RemoveAt(SelectedProductIndex);
		}


		// ----------------------------

		// Part Methods

		// add new part
		public static void AddPart(Part part)
		{
			Parts.Add(part);
		}

		// remove part from list
		public static bool DeletePart(Part part)
		{
			bool checkk = false;
			foreach (Part p in Parts)
			{
				if (p.PartID == part.PartID)
				{
					Parts.Remove(p);
					checkk = true;
				}
				else
				{
					MessageBox.Show("Part does not exist");
					checkk |= false;
				}
			}
			return checkk;
		}

		// lookup part
		public static Part LookupPart(int PartID)
		{
			foreach (Part p in Parts)
			{
				if (p.PartID == PartID)
				{
					return p;
				}
			}
			return null;
		}

		// update part
		public static void UpdatePart(int PartID, Part part)
		{
			foreach (Part p in Parts)
			{
				p.PartID = part.PartID;
				p.Name = part.Name;
				p.Price = part.Price;
				p.InStock = part.InStock;
				p.Min = part.Min;
				p.Max = part.Max;
				return;
			}
		}
		
		public static void ReplacePart(Part part, Part productPart)
		{
			int partid = part.PartID;
			int productpartid = productPart.PartID;

			string partname = part.Name;
			string productpartname = productPart.Name;

			decimal partprice = part.Price;
			decimal productpartprice = productPart.Price;

			int partinstock = part.InStock;
			int productpartinstock = productPart.InStock;

			int partmin = part.Min;
			int productpartmin = productPart.Min;

			int partmax = part.Max;	
			int productpartmax = productPart.Max;

			if (partid == productpartid)
			{
				if ((partname != productpartname) ||
					(partprice != productpartprice) ||
					(partinstock != productpartinstock) ||
					(partmin != productpartmin) ||
					(partmax != productpartmax))
				{
					CurrentProduct.AssociatedParts.Remove(productPart);
					CurrentProduct.AssociatedParts.Add(part);
				}
			}
		}

	}
}
