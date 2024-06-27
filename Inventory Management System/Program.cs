namespace Inventory_Management_System
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Inhouse wheel = new Inhouse("Wheel", 18.99M, 20, 5, 25, 120);
			Inhouse pedal = new Inhouse("Pedal", 8.22M, 11, 5, 25, 121);
			Outsourced chain = new Outsourced("Chain", 8.33M, 12, 5, 25, "Everlast");
			Outsourced seat = new Outsourced("Seat", 4.55M, 15, 2, 15, "Everlast");

			Product redbicycle = new Product("Red Bicycle", 11.44M, 15, 1, 25);
			Product yellowbicycle = new Product("Yellow Bicycle", 9.66M, 19, 1, 20);
			Product bluebicycle = new Product("Blue Bicycle", 12.77M, 5, 1, 25);

			Inventory.Parts.Add(wheel);
			Inventory.Parts.Add(pedal);
			Inventory.Parts.Add(chain);
			Inventory.Parts.Add(seat);

			Inventory.Products.Add(redbicycle);
			Inventory.Products.Add(yellowbicycle);
			Inventory.Products.Add(bluebicycle);

			redbicycle.AssociatedParts.Add(wheel);
			redbicycle.AssociatedParts.Add(pedal);
			redbicycle.AssociatedParts.Add(chain);
			redbicycle.AssociatedParts.Add(seat);

			yellowbicycle.AssociatedParts.Add(wheel);
			yellowbicycle.AssociatedParts.Add(pedal);
			yellowbicycle.AssociatedParts.Add(chain);
			yellowbicycle.AssociatedParts.Add(seat);

			bluebicycle.AssociatedParts.Add(wheel);
			bluebicycle.AssociatedParts.Add(pedal);
			bluebicycle.AssociatedParts.Add(chain);
			bluebicycle.AssociatedParts.Add(seat);


			
			Application.EnableVisualStyles();
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}