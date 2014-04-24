using System;

namespace COMP2614HomeLab02
{
	public enum Status
	{ForSale, Sold, Shipped}


	public class Product
	{
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
		}
	}
}



/*Product class
Your program must adhere to the following design:
 Write a class named Product in a separate source file.
 Write any appropriate constructor or constructors.
 Create three properties for this class: Description, Price and ProductStatus. Use
appropriate data types.
 For the ProductStatus, you will also need to define the data type, which for this lab must be
an enumeration named Status. The enumeration has three values: ForSale, Sold and
Shipped.
 Write three methods for the Product class: Sell, Ship and ToString.
 Sell changes the ProductStatus to Sold, but only if the object's ProductStatus is
ForSale, otherwise, throw an Exception with an appropriate error message:
throw new Exception(“Appropriate Error Message Here”);
 Ship changes the ProductStatus to Shipped, but only if the object's ProductStatus is
Sold, otherwise, throw an Exception with an appropriate error message:
throw new Exception(“Appropriate Error Message Here”);
 Override the Object class' ToString method, like this:
public override string ToString()
{ ...
Return (do not print, but return) a string that contains the ProductStatus, Description
and Price of the object.
*/
