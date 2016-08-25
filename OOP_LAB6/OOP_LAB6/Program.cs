using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation - Access Modifier 를 이용한 은닉성  

            //Inheritance - Shape 클래스를 Base 로 한 Derivaed Class 를 사용해 상속으로 코드를 재활용 
            double area;
            Boolean result;

            Triangle t = new Triangle(3, 6, 9);
            Rectangle r = new Rectangle(3, 6);
            Circle c = new Circle(3);
            Ellipse e = new Ellipse(3, 5);

            t.Draw();
            area = t.GetArea();
            Console.WriteLine("삼각형 면적 : {0}", area);

            if (result = t.IsEquilateral)
            {
                Console.WriteLine("이등변 삼각형 입니다.");
            }
            else
            {
                Console.WriteLine("이등변 삼각형이 아닙니다.");
            }


            r.Draw();
            area = r.GetArea();
            if(result = r.IsSpuqre)
            {
                Console.WriteLine("정사각형 입니다.");
            }
            else
            {
                Console.WriteLine("정사각형이 아닙니다.");
            }


            c.Draw();
            area = c.GetArea();
            Console.WriteLine("원의 면적 : {0}", area);


            e.Draw();
            area = e.GetArea();
            Console.WriteLine("타원의 면적 : {0}", area);


            //Polymorphism 예제 구현 

            PolymorphismSample p = new PolymorphismSample();

            p.DrawShape(t);
            p.DrawShape(r);
            p.DrawShape(c);
            p.DrawShape(e);
        }
    }
}
