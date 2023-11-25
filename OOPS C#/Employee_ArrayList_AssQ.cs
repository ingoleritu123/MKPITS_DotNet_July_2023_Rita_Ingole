using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Arrylist_AssQ
{
    class Employee
    {
        public string Emp_name;
        public int Emp_no;
        public int salary;
        public string Designation;
        public Employee(string Emp_name,int Emp_no,int salary,string Designation)
        {
            this.Emp_name = Emp_name;
            this.Emp_no = Emp_no;
            this.salary = salary;
            this.Designation = Designation;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("riya", 456, 60000, "employee");
            Employee e2 = new Employee("rita", 556, 70000, "employee");
            Employee e3 = new Employee("riva", 656, 80000, "employee");

            ArrayList al= new ArrayList();
            al.Add(e1);
            al.Add(e2);
            al.Add(e3);


            foreach(Employee e in al)
            {
                Console.WriteLine("Emp_Name:" + e.Emp_name + "\n");
                Console.WriteLine("Emp_no:" + e.Emp_no + "\n");
                Console.WriteLine("Salary:" + e.salary + "\n");
                Console.WriteLine("Designation:" + e.Designation + "\n");
                Console.WriteLine("--------------------------------");

            }
            Console.ReadKey();

        }
    }
}
