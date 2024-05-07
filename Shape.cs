using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Shape
    {
        
        //Properties
        public string Color { get; set; }
        public bool IsFilled { get; set; }
        public double BorderSize { get; set; }

        // Defualt constructor
        public Shape() { }

        // Overloaded constructor
        public Shape(string color)
        {
            this.Color = color;
        }

        // Overloaded constructor
        public Shape(string color, bool t)
        {
            this.Color = color;
            this.IsFilled = t;
        }

        protected virtual void DisplayShapeInfo()
        {
            Console.WriteLine("Color: {0}, IsFilled: {1}, BorderSize: {2},", Color, IsFilled, BorderSize);
        }
    }
//Thanks for looking
}
