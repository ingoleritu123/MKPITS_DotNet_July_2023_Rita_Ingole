using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseclassempbymethod
{
    class Employee
    {
        protected int salary;
    }
    class Programmer:Employee
    {
        public int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("salary:" + salary);
            Console.WriteLine("Bonus:" + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.getdata(3000, 400);
            p.displaydata();
            Console.ReadLine(); 
        }
    }
}
