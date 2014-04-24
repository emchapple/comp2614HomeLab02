using System;
using System.Text;
using System.Reflection;

namespace COMP2614HomeLab02
{
	public enum Status
	{ForSale, Sold, Shipped}


	public class Product
	{
		public static string KEY_SEPARATOR = "=";
		public static string VALUE_SEPARATOR = ";";

		private string description;
		public string Description {
			get{ return description; }
			set{ description = value; }
		}

		private decimal price;
		public decimal Price {
			get{ return price; }
			set{ price = value; }
		}

		private Status productStatus;
		public Status ProductStatus {
			get{ return productStatus; }
			set{ productStatus = value; }
		}


		public Product ()
		{
			productStatus = Status.ForSale;
		}

		public Product(string description, Status productStatus, decimal price)
		{
			this.description = description;
			this.productStatus = productStatus;
			this.price = price;
		}


//		Sell changes the ProductStatus to Sold, but only if the object's ProductStatus is
//			ForSale, otherwise, throw an Exception with an appropriate error message:
//			throw new Exception(“Appropriate Error Message Here”);
		public void Sell()
		{
			if (productStatus == Status.ForSale)
			{
				productStatus = Status.Sold;
			} else 
			{
				throw new Exception( "Can't sell a product that is not for sale." );
				}
		}


//		Ship changes the ProductStatus to Shipped, but only if the object's ProductStatus is
//			Sold, otherwise, throw an Exception with an appropriate error message:
//			throw new Exception(“Appropriate Error Message Here”);
		public void Ship()
		{
			if (productStatus == Status.Sold) {
				productStatus = Status.Shipped;
			} else 
			{
				throw new Exception ("Can't ship unsold product.");
			}
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder (1000);

			PropertyInfo[] properties = this.GetType ().GetProperties ();

			foreach(PropertyInfo property in properties)
			{
				sb.Append (property.Name);
				sb.Append (KEY_SEPARATOR);
				sb.Append(property.GetValue(this, null));
				sb.Append (VALUE_SEPARATOR);
			} 

			return sb.ToString ();

		}

	}
}




