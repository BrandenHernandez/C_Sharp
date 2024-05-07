//10-19-2017 / edited 10-20-2017
using System;

namespace OrderTest
{
    class Order
    {
        // static decimal named Total available for public access plus other memebers (10pt)
        public static decimal Total; // Order property

        public string CustomerName { get; private set; } // Auto-implemented Name property
        public decimal SubTotal { get; set; } // Auto-implemented Total property
        public int OrderNum { get; set; } // Auto-implemented OrderNum property
        public string Item1 { get; set; } // Auto-implemented First property
        public string Item2 { get; set; } // Auto-implemented Second property
        public string Item3 { get; set; } // Auto-implemented Third property
        public string Item4 { get; set; } // Auto-implemented Fourth property

        // Defualt constructor
        public Order()
        {
            // The void
        }

        // Order constructor that receives seven  parameters
        public Order(int number, string name, string first, string second, string third, string fourth, decimal tab)
        {
            OrderNum = number; // Order Number
            CustomerName = name; // Name
            Item1 = first; // Food order
            Item2 = second; // Food order
            Item3 = third; // Food order
            Item4 = fourth; // Food order
            SubTotal = tab; // Running tally
        }

        public string Name // Name property
        {
            get // Getter
            {
                return CustomerName;
            }

            set // Setter
            {
                CustomerName = value; // Can only be used within the class
            }
        }

        public int Number
        {
            get // Getter
            {
                return OrderNum; // Order number
            }

            set => OrderNum = value; // Lambda
        }

        public string Order1 // #1 property
        {
            get // Getter
            {
                return Item1; // First order
            }

            set => Item1 = value; // Lambda
        }

        public string Order2 // #2 property
        {
            get // Getter
            {
                return Item2; // Second order
            }

            set => Item2 = value; // Lambda
        }

        public string Order3 // #3 property
        {
            get // Getter
            {
                return Item3; // Third order
            }

            set => Item3 = value; // Lambda
        }

        public string Order4 // #4 property
        {
            get // Getter
            {
                return Item4; // Fourth order
            }

            set => Item4 = value; // Lambda
        }

        public decimal Tab // Running tab
        {
            get // Getter
            {
                return SubTotal; // Order subtotal
            }

            set => SubTotal = value; // Lambda
        }

        // Create a method called “DisplayOrder” that uses all of the properties created in step 3 to print the order out to the console.
        public static void DisplayOrder(string CustomerName, int OrderNum, string Item1, string Item2, string Item3, string Item4, decimal SubTotal)
        {
            Console.WriteLine($"\nHello {CustomerName}! Your order #{OrderNum} has items: {Item1}, {Item2}, {Item3}, and {Item4}. Your subtotal today is: {SubTotal:C}\n");
        }
    }
    // Thanks for looking
}
