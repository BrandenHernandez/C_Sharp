// Add 3 classes to the project that extend Shape and implement IChangeColor. 
using System;

namespace ShapeTest
{
	class Circle : Shape, IChangeColor
	{
        //Add member such as width, height, base, diameter, etc., to each of the derived classes as need to calculate the area in each implementation. 
        string shape = "Circle";
        double radius = 35;
        double pi = Math.PI;
        double area;

        public void ChangeColor(string color)
		{
			Console.WriteLine($"The color of the {shape} is now {color}");
            Console.WriteLine(); // New Line
        }

		public override void GetArea()
		{
			area = pi * (radius * radius);
            Console.WriteLine($"The area of the {shape} with radius {radius} is {area}.");
        }
	}
// Thanks for looking
}
