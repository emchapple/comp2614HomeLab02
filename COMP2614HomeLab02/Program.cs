using System;

namespace COMP2614HomeLab02
{


	public class Program
	{


		public Program ()
		{
		}

		public static void Main()
		{
			int numProducts = 3;
			Product[] inventory = new Product[numProducts];

			Product product1 = new Product ();
			product1.Description = "Green blouse";
			product1.ProductStatus = Status.ForSale;
			product1.Price = 69.99m;
			inventory [0] = product1;

			Product product2 = new Product ("Shampoo",Status.ForSale, 5.95m);
			inventory [1] = product2;

			Product product3 = new Product { Description = "Cat Food (10 kg)",
											ProductStatus = Status.ForSale,
											Price = 32.00m};
			inventory [2] = product3;


			Console.WriteLine (product3);



		}


		/*
		Create an array to hold three Product objects
		 Instantiate three Product objects using the three different ways shown in class.
			You will have to write the appropriate constructor(s) in your Product class to support this:
			o Product 1: Call the default constructor and then set the Properties
			o Product 2: Call a parameterized constructor and pass the data as parameters
			o Product 3: Use the object initializer syntax
			 Add the three Product objects to the array
			 Display the products
			 Sell the first product
			 Display the products again
			 Sell the second product
			 Display the products again
			 Ship the second product
			 Display the products one final time
			*/

	}
}

