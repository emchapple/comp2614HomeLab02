using System;

namespace COMP2614HomeLab02
{


	public class Program
	{
		private static Product[] inventory;

		public Program ()
		{
		}

		public static void Main()
		{
			int numProducts = 3;
			inventory = new Product[numProducts];

			Product product1 = new Product ();
			product1.Description = "Green blouse";
			product1.ProductStatus = Status.ForSale;
			product1.Price = 69.99m;


			Product product2 = new Product ("Shampoo",Status.ForSale, 5.95m);

			Product product3 = new Product { Description = "Cat Food (10 kg)",
											ProductStatus = Status.ForSale,
											Price = 32.00m};
			inventory [0] = product1;
			inventory [1] = product2;
			inventory [2] = product3;

			DisplayInventory ();
			SellInventoryItem (0);

			DisplayInventory ();
			SellInventoryItem (1);

			DisplayInventory ();
			ShipInventoryItem (1);
			DisplayInventory ();
		}

		public static string FormatForApplication(Product product)
		{
			return String.Format ("{0}:  {1} for {2}", product.ProductStatus, product.Description, product.Price);
		}

		public static void DisplayInventory()
		{
			foreach (Product product in inventory) 
			{
				Console.WriteLine (FormatForApplication (product));
			}

			Console.WriteLine ("\n");
		}

		public static void SellInventoryItem(int index)
		{
			Console.WriteLine ( GetMessage("Selling", index));
			inventory [index].Sell ();
		}

		public static void ShipInventoryItem(int index)
		{
			Console.WriteLine ( GetMessage( "Shipping", index));
			inventory [index].Ship ();
		}

		public static string GetMessage(string verb, int index)
		{
			return String.Format("{0} product {1}...", verb, index);
		}

	

	}
}

