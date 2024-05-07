// Midterm 10/19/2017 Truckee Meadows Community College
// Edited 10/20/2017
// Branden Lawrence

/* Create an application that will allow the user to enter an order, delete an order, 
 * or display the total of all orders in the system. You will use techniques, methods, 
 * classes, and other statements we have learned so far to accomplish this assignment.
 */
using System;

namespace OrderTest
{
    class OrderTest
    {
        static void Main(string[] args)
        {
            // Menu Variables
            char selection;
            int orderEdit;
            int oNum;
            bool endMenu = false;

            // Welcoming message
            Console.WriteLine("Welcome to Branden's restaurant!");

            do // Do/While loop
            {
                // Create an order object and assign it to order1
                Order order1 = new Order(123, "Fred_Flintstone", "Beef", "Rice", "Bread", "Milk", 56.75M);

                // Create an order object and assign it to order2
                Order order2 = new Order(456, "Barney_Rubble", "Chicken", "Noodles", "Broth", "Soda", 48.25M);

                // Create an order object and assign it to order3 using the defualt constructor
                Order order3 = new Order();

                // Add the SubTotal of order1 to the Total of the Order class
                Order.Total = UpdateTotal(order1.SubTotal);

                // Add the SubTotal of order2 to the Total of the Order class
                Order.Total = UpdateTotal(order2.SubTotal);

                // Add the SubTotal of order3 to the Total of the Order class
                Order.Total = UpdateTotal(order3.SubTotal);

                // Write menu to console
                Console.WriteLine("\nPlease make a selection below..."
                    + "\nA) Begin an Order\nB) Delete an Order\nC) Display Total of All Orders\nD) Exit\n");
                selection = char.Parse(Console.ReadLine()); // Read the input of the text

                // Selection is checked in a switch statement
                switch (selection)
                {
                    case 'A': // If 'A' was selected
                              // Order Number
                        order3.Number = oNum = rnd.Next(1000); // This is the OrderNum of the order3 object created.
                                                               // Order name
                        Console.WriteLine("Please enter your name (with no spaces): ");
                        order3.Name = Console.ReadLine(); // Read the input of the text
                                                          // Item1
                        Console.WriteLine("Please enter your first choice (with no spaces): ");
                        order3.Item1 = Console.ReadLine(); // Read the input of the text
                                                           // Item1 Price
                        Console.WriteLine($"Please enter a price for {order3.Item1}: ");
                        order3.SubTotal += decimal.Parse(Console.ReadLine()); // Read the input of the text
                                                                              // Item2
                        Console.WriteLine("Please enter your second choice (with no spaces): ");
                        order3.Item2 = Console.ReadLine(); // Read the input of the text
                                                           // Item2 Price
                        Console.WriteLine($"Please enter a price for {order3.Item2}: ");
                        order3.SubTotal += decimal.Parse(Console.ReadLine()); // Read the input of the text
                                                                              // Item3
                        Console.WriteLine("Please enter your third choice (with no spaces): ");
                        order3.Item3 = Console.ReadLine(); // Read the input of the text
                                                           // Item3 Price
                        Console.WriteLine($"Please enter a price for {order3.Item3}: ");
                        order3.SubTotal += decimal.Parse(Console.ReadLine()); // Read the input of the text
                                                                              // Item4
                        Console.WriteLine("Please enter your last choice (with no spaces): ");
                        order3.Item4 = Console.ReadLine(); // Read the input of the text
                                                           // Item4 Price
                        Console.WriteLine($"Please enter a price for {order3.Item4}: ");
                        order3.SubTotal += decimal.Parse(Console.ReadLine()); // Read the input of the text
                                                                              // Call the UpdateTotal method with order3.SubTotal as the argument
                        UpdateTotal(order3.SubTotal); // Add order3.SubTotal to Order.Total

                        // Call the DisplayOrder method of the order3 object.
                        Order.DisplayOrder(order3.Name, order3.Number, order3.Item1, order3.Item2, order3.Item3, order3.Item4, order3.SubTotal);

                        break;
                    case 'B': // If 'B' was selected
                              // ask the user if they wish to delete order 1 or order 2.
                        Console.WriteLine("Would you like to delete order 1 or order 2?");
                        orderEdit = int.Parse(Console.ReadLine());

                        // If/else statement on the orderEdit variable to decide which of the orders to delete.
                        if (orderEdit == 1) // If order1 is selected
                        {
                            order1.Name = "";  // Name
                            order1.Number = 1; // Number
                            order1.Item1 = ""; // Item 1
                            order1.Item2 = ""; // Item 2
                            order1.Item3 = ""; // Item 3
                            order1.Item4 = ""; // Item 4
                            Order.Total -= order1.SubTotal; // Subtract subtotal from Total
                            order1.SubTotal = 0.00M; // Zero subtotal
                            Order.DisplayOrder(order1.Name, order1.Number, order1.Item1, order1.Item2, order1.Item3, order1.Item4, order1.SubTotal); // Display order1
                        }
                        else if (orderEdit == 2) // If order2 is selected
                        {
                            order2.Name = null;  // Name
                            order2.Number = 2; // Number
                            order2.Item1 = null; // Item 1
                            order2.Item2 = null; // Item 2
                            order2.Item3 = null; // Item 3
                            order2.Item4 = null; // Item 4
                            Order.Total -= order2.SubTotal; // Subtract subtotal from Total
                            order2.SubTotal = 0.00M; // Zero subtotal
                            Order.DisplayOrder(order2.Name, order2.Number, order2.Item1, order2.Item2, order2.Item3, order2.Item4, order2.SubTotal); // Display order2
                        }
                        break;
                    case 'C': // If 'C' was selected
                        DisplayTotal();
                        break;
                    case 'D': // If 'D' was selected
                        Console.Write("Goodbye\n"); // Print message
                        endMenu = true; // End loop
                        break;
                    default: // Defualt if non were properly selected
                        Console.Write("Please Try Again\n"); // Loop back
                        break;

                }
            } while (endMenu = false || selection != 'D');
        }

        /**
		 * In OrderTest class create two static methods
		 * One called UpdateTotal that takes a decimal as an argument. 
		 */

        //update the static Total variable of the Order class
        static decimal UpdateTotal(decimal SubTotal)
        {
            Order.Total += SubTotal; // The decimal passed to the method is added to Total

            return Order.Total; // Return the Total
        }

        /**
		 * The second static method should be called DisplayTotal.
		 * This method takes no arguments but prints the Total from the Order class out to the console when called.
		 */

        // Print Total
        static void DisplayTotal()
        {
            Console.Write($"Your total today is: {Order.Total:C}\n"); // Display Total in currency format
        }

        // new static Random object (5pt)
        private static Random rnd = new Random(); // Create random object and assign to rnd
    }
    // Thanks for looking
}
