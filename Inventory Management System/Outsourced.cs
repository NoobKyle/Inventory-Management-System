using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	public class Outsourced : Part
	{
		public Outsourced(string text, decimal v2, int v3, int v4, int v5, string v6)
			:base(text, v2, v3, v4, v5)
		{
			CompanyName = v6;
		}
		
		public Outsourced(int v1, string text, decimal v2, int v3, int v4, int v5, string v6)
			:base(v1, text, v2, v3, v4, v5)
		{
			CompanyName = v6;
		}

		public string CompanyName { get; set; }

	}
}
