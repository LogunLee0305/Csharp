using System;
using TriangleLib;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
                double triangleLenth;
                double triangleArea;
                string methodandPram;

                var t = new Triangle(2, 2, 3);

                if (t.CheckIsoscelesTriangle())
                {
                    Console.WriteLine("이 삼각형은 이등변 삼각형 입니다.");
                }

                else if (t.CheckRegularTriangle())
                {
                    Console.WriteLine("이 삼각형은 정삼각형 입니다.");
                }

                else
                    Console.WriteLine("이 삼각형은 정삼각형이나 이등변 삼각형이 아닙니다.");

                triangleLenth = t.GetTriangleAroundLenth();
                triangleArea = t.GetTriangleArea();

                Console.WriteLine("삼각형의 변의 길이 : {0}", triangleLenth);
                Console.WriteLine("삼각형의 넓이 : {0}", triangleArea);

                methodandPram = t.ToString();
                Console.WriteLine(methodandPram);
       }
    }
}