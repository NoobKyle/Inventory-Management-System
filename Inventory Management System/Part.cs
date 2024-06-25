using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	public class Part
	{
		public static int count = 1;

		public Part(string text, decimal v2, int v3, int v4, int v5)
		{
			PartID = count++;
			Name = text;
			Price = v2;
			InStock = v3;
			Min = v4;
			Max = v5;
		}

		public Part(int v1, string text, decimal v2, int v3, int v4, int v5)
		{
			PartID = v1;
			Name = text;
			Price = v2;
			InStock = v3;
			Min = v4;
			Max = v5;
		}

		// Part Variables
		public int PartID { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public int InStock { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }

	}
}
 