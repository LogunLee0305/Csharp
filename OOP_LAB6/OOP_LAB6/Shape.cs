using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Draw Shape");
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }
}
