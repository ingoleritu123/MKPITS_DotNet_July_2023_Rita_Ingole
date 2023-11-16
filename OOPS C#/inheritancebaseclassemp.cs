using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritancebaseclassimployee
{
    public class Employee
    {
        public int salary=40000;
    }
     public class Programmer:Employee
    {
        public int bonus=4000;
    }
    class Testinheritance
    {
        public static void Main(string[] args)
        {
            Programmer p = new Programmer();

            Console.WriteLine("Salary:" + p.salary);
            Console.WriteLine("Bonus:" + p.bonus);
            Console.ReadLine();

            // this program in fild
        }
    }
}
