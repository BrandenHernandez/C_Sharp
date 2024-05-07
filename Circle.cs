using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    class Circle : Shape
    {
       public double Radius { get; set; }

        // Constructor
        public Circle(string r, bool t) : base(r,t) { }

        public double FindDiameter()
        {
            return this.Radius * 2;
        }

        protected override void DisplayShapeInfo()
        {
            Console.WriteLine("Radius: {0}", Radius);
            base.DisplayShapeInfo();
        }

        public void DSI()
        {
            this.DisplayShapeInfo();
        }
    }
//Thanks for looking
}
