using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System
{
	public class Inhouse : Part
	{
		public Inhouse(string text, decimal v2, int v3, int v4, int v5, int v6)
			:base(text, v2, v3, v4, v5)
		{
			MachineID = v6;
		}
		
		public Inhouse(int v1, string text, decimal v2, int v3, int v4, int v5, int v6)
			:base(v1, text, v2, v3, v4, v5)
		{
			MachineID = v6;
		}

		public int MachineID { get; set; }

	}
}
