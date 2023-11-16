using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseclasspersonbyfilds
{
    public class Person
    {
        public string Name;
        public string Address;
    }
    public class Employee : Person
    {
        public int emp_no;
        public int salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Name = "Rita";
            emp.salary = 30000;
            emp.Address = "Nagpur";
            emp.emp_no = 234;


            Console.WriteLine("Name:" +emp.Name);
            Console.WriteLine("Address:" + emp.Address);
            Console.WriteLine("Emp_no:" + emp.emp_no);
            Console.WriteLine("Salary:" + emp.salary);
            Console.ReadKey();


        }
    }
}
