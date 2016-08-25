using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> person = new List<Employee>();
            person.Add(new Employee() { Id = 1, Age = 29, Rank = 1, Salaly = 4300 });
            person.Add(new Employee() { Id = 2, Age = 38, Rank = 5, Salaly = 3300 });
            person.Add(new Employee() { Id = 5, Age = 42, Rank = 4, Salaly = 3500 });
            person.Add(new Employee() { Id = 4, Age = 28, Rank = 2, Salaly = 6300 });
            person.Add(new Employee() { Id = 6, Age = 23, Rank = 7, Salaly = 6700 });

            //List 출력 
            foreach (Employee aPart in person)
            {
                Console.WriteLine(aPart);
            }

            //"---ID 순 정렬---"
            Console.WriteLine();
            Console.WriteLine("---ID 순 정렬---");
            Quicksorter.QuickSort(person);

            foreach (Employee aPart in person)
            {
                Console.WriteLine(aPart);
            }

            //"---Age 순 정렬---"  
            Console.WriteLine();
            Console.WriteLine("---Age 순 정렬---");
            Quicksorter.QuickSort(person, new Employee.SortByAge());

            foreach (Employee aPart in person)
            {
                Console.WriteLine(aPart);
            }

            //---월급 순 정렬---
            Console.WriteLine();
            Console.WriteLine("---월급 순 정렬---");
            Quicksorter.QuickSort(person, new Employee.SortBySalary());

            foreach (Employee aPart in person)
            {
                Console.WriteLine(aPart);
            }
        }
    }
}