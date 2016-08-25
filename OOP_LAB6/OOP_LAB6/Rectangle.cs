using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Boolean IsSpuqre
        {
            get
            {
                if (Height == Width)
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle({0},{1})", Height, Width);
        }

        public override double GetArea()
        {
            return this.Height * this.Width; 
        }
    }
}
