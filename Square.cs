// Add 3 classes to the project that extend Shape and implement IChangeColor. 
using System;

namespace ShapeTest
{
	class Square : Shape, IChangeColor
	{
        //Add member such as width, height, base, diameter, etc., to each of the derived classes as need to calculate the area in each implementation. 
        public string shape = "Square";
        double side = 10;
        double area;

		public void ChangeColor(string color)
		{
			Console.WriteLine($"The color of the {shape} is now {color}");
            Console.WriteLine(); // New Line
        }

		public override void GetArea()
		{
            area = side * side;
            Console.WriteLine($"The area of the {shape} with sides equal to {side} is {area}.");
        }
	}
	// Thanks for looking
}
