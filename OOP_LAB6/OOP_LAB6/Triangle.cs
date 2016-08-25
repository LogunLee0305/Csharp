using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public Boolean IsEquilateral
        {
            get
            {
                if (Side1 == Side2 || Side2 == Side3)
                { return true; }

                else
                { return false; }
            } 
        }

        public Triangle(int side1, int side2, int side3)
        {
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Triangle({0},{1},{2}", Side1, Side2, Side3);
        }

        public override double GetArea()
        {
            double s = (double)(Side1 + Side2 + Side3 / 2);
            double val = (s - Side1) * (s - Side2) * (s - Side3) * s;
            double areaValue = Math.Sqrt(val);
            return areaValue;
        } 
    }
}
