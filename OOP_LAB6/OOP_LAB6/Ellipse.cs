using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Ellipse : Shape
    {
        public double RadiusX { get; set; }
        public double RadiusY { get; set; }

        public Ellipse(double x, double y)
        {
            this.RadiusX = x;
            this.RadiusY = y;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Ellipse(3,4)", RadiusX, RadiusY);
        }

        public override double GetArea()
        {
            return 3.14 * RadiusX * RadiusY;
        }
    }
}
