using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Sort
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public int Rank { get; set; }
        public int Salaly { get; set; }

        //Id 의한 디폴트 소팅에 사용됨

        //ICOmparer 인터페이스를 상속하므로 Compare 메소드 정의 

        public int CompareTo(Employee others)
        {
            return this.Id.CompareTo(others.Id);
        }
    }

    public class SortByAge : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    public class SortByRank : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return y.Rank.CompareTo(x.Rank); // x, y 위치 변경으로 내림차순 구현 
        }
    }

    public class SortBySalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return y.Salaly.CompareTo(x.Salaly); // x, y 위치 변경으로 내림차순 구현 
        }
    }

}
