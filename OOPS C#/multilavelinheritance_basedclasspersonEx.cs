using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilavelinheritance_Ex_basedclassperson
{
    public class Person
    {
        string Name;
        string Address;
        public void getPersondata(string Name,string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }
        public void displayPersondata()
        {
            Console.WriteLine("Name:"+Name);
            Console.WriteLine("Address:" + Address);
        }
    }
    public class Employee:Person
    {
        int Emp_Id;
        int Salary;
        public void getEmployeedata(int Emp_Id,int Salary)
        {
            this.Emp_Id = Emp_Id;
            this.Salary = Salary;
        }
        public void displayEmployeedata()
        {
            Console.WriteLine("Emp_Id:" + Emp_Id);
            Console.WriteLine("Salary:" + Salary);
        }
        
    }
    public class Parttime_Emp:Employee
    {
        int no_of_hours;
        public void getParttimeEmpdata(int no_of_hours)
        {
            this.no_of_hours = no_of_hours;
        }
        public void displayParttimeEmpdata()
        {
            Console.WriteLine("No_Of_Hours:" + no_of_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Parttime_Emp p1 = new Parttime_Emp();
            p1.getPersondata("Rita", "nagpur");
            p1.getEmployeedata(345, 67000);
            
            p1.getParttimeEmpdata(5);
            p1.displayPersondata();
            p1.displayEmployeedata();
            p1.displayParttimeEmpdata();
            

            Console.ReadLine();

        }
    }
}
