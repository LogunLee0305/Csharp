using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Circle({0})", Radius);
        }

        public override double GetArea()
        {
            return (Radius * Radius * 3.14);
        }
    }
}
