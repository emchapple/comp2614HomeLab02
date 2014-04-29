using System;
using System.Text;
using System.Reflection;

namespace COMP2614HomeLab02
{
	public enum Status
	{ForSale, Sold, Shipped}

	/// <summary>
	/// Simple class to represent a Product that has a price, description, and for sale status, and can be sold and shipped. 
	/// </summary>
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


		/// <summary>
		/// Sell changes the ProductStatus to Sold, but only if the object's ProductStatus is ForSale.
		/// Otherwise, an exception is thwon.
		/// </summary>
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


		/// <summary>
		/// Ship changes the ProductStatus to Shipped, but only if the object's ProductStatus is
		///	Sold. Otherwise, an exception is thrown.
		/// </summary>
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




