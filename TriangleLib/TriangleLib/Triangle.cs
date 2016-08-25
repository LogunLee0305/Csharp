using System;

namespace TriangleLib
{
    public class Triangle
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.FirstSide = firstSide;
            this.SecondSide = secondSide;
            this.ThirdSide = thirdSide;
        }

        public Boolean CheckRegularTriangle()
        {
            if (FirstSide == SecondSide && SecondSide == ThirdSide)
            { return true; }

            else
            { return false; }
        }

        public Boolean CheckIsoscelesTriangle()
        {
            if (FirstSide == SecondSide || FirstSide == ThirdSide || SecondSide == ThirdSide)
            { return true; }

            else
            { return false; }
        }

        public double GetTriangleAroundLenth()
        {
            double sum = FirstSide + SecondSide + ThirdSide;
            return sum;
        }

        public double GetTriangleArea()
        {
            double s = (double)(GetTriangleAroundLenth() / 2);
            double val = (s - FirstSide) * (s - SecondSide) * (s - ThirdSide) * s;
            double areaValue = Math.Sqrt(val);
            return areaValue;
        }

        public override string ToString()
        {
            string show = "Triangle(" + FirstSide + "," + SecondSide + "," + ThirdSide + ")";
            return show;
        }
    }
}
