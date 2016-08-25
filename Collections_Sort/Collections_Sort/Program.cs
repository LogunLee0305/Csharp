using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Sort
{
    class Program
    {
        static Employee[] empArray = new Employee[]
        {
               new Employee { Id=1, Age=29, Rank=1, Salaly=4300},
               new Employee { Id=2, Age=38, Rank=5, Salaly=3300},
               new Employee { Id=5, Age=42, Rank=4, Salaly=3500},
               new Employee { Id=4, Age=28, Rank=2, Salaly=6300},
               new Employee { Id=3, Age=33, Rank=1, Salaly=8300}
        };

        static void Main(string[] args)
        {
            //Id 순
            Array.Sort(empArray);
            PrintTable("ID_오름차순");
            //Id 순

            //나이순
            SortByAge a = new SortByAge();
            Array.Sort(empArray, a);
            PrintTable("나이_오름차순");
            // 나이순

            //직급순
            SortByRank r = new SortByRank();
            Array.Sort(empArray, r);
            PrintTable("직급_내림차순");
            //직급순 

            //연봉순
            SortBySalary s = new SortBySalary();
            Array.Sort(empArray,s);
            PrintTable("연봉_오름차순");
            //연봉순
        }

        public static void PrintTable(string sort)
        {
            Console.WriteLine();
            Console.WriteLine("Sorting...{0}", sort);
            Console.WriteLine();

            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine("{0} ,{1} ,{2} ,{3}", empArray[i].Id, empArray[i].Age, empArray[i].Rank, empArray[i].Salaly);
            }
        }
    }
}
