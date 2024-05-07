/* Ex. 9.3 (Querying an Array of Invoice Objects) Use the class Invoice.cs to create an array of invoice objects.
 Class Invoice includes four properties- a PartNumber (type int), a PartDesciption (type string)
 a Quantity of the item being purchased (type int), and a Price (type decimal)
 
  a) Use LINQ to sort the Invoice objects by PartDescription
  b) Use LINQ to sort the invoice object by Price
  c) Use LINQ to select the PartDecription and Quantity and sort the results by Quantity
  */

  //VeryAble 11-9-2017
using System;
using System.Linq;

namespace InvoiceQuery
{
	class InvoiceQuery
	{
		static void Main(string[] args)
		{
			// Initialize an array of Invoices
			var invoice = new[]
			{
				new Invoice(455, " Brakes", 4, 29),
				new Invoice(1575, " Battery", 2, 100),
				new Invoice(2654, " Altenator", 1, 299),
				new Invoice(4568, " Tires", 4, 200),
				new Invoice(57899, " Lug Nuts", 20, 10)
			};

			// ---------------------------------------------------------------------------------------------------------------------------
			
			// a) Use LINQ to sort the Invoice objects by PartDescription
			var descriptionSorter =
				from i in invoice
				orderby i.PartDescription
				select i;

			// Display
			Console.WriteLine("By Description (Alphabetically)"); // Odered By
			Console.WriteLine("Number Description\tQuantity Price per unit"); //  Header

			foreach (var element in descriptionSorter)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine("");

			// b) Use LINQ to sort the invoice object by Price
			var priceSorter =
				from i in invoice
				orderby i.Price
				select i;

			// Display
			Console.WriteLine("By Price"); // Odered By
			Console.WriteLine("Number Description\tQuantity Price per unit"); //  Header

			foreach (var element in priceSorter)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine("");

			// c) Use LINQ to select the PartDecription and Quantity and sort the results by Quantity
			var quantitySorter =
				from i in invoice
				orderby i.PartDescription, i.Quantity
				orderby i.Quantity
				select i;

			// Display
			Console.WriteLine("By Quantity"); // Odered By
			Console.WriteLine("Number Description\tQuantity Price per unit"); //  Header

			foreach (var element in quantitySorter)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine("");
		}
	}
// Thanks for looking
}
