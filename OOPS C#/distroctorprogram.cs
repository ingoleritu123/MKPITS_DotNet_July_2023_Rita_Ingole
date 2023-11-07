using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distroctor_program
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("call constructor");

        }
        ~Employee()
        {
            Console.WriteLine("call distructor");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.ReadKey();

            Employee emp1 = new Employee();
            Console.ReadKey();
        }
    }
}
