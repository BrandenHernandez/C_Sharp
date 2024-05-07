// Create a new project called ShapeTest.  
using System;

namespace ShapeTest
{
	class ShapeTest
	{
		static void Main(string[] args)
		{
			// Instantiate an instance of all these Shapes in the Main method and call the the GetArea and ChangeColor methods for each.
			Circle c = new Circle();
			c.GetArea();
			c.ChangeColor("Red");

			Square s = new Square();
			s.GetArea();
			s.ChangeColor("Green");

			Triangle t = new Triangle();
			t.GetArea();
			t.ChangeColor("Black");

			// The change color method should change the color of the shape. Demonstrate this working.
		}
	}
// Thanks for looking
}
