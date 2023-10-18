using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impdetailsinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string emp_name, des;
            int emp_no, basic_salary;
            float bonus = 0, total_salary ;

            Console.WriteLine("Enter Your Name :");
            emp_name = Console.ReadLine();
            Console.WriteLine("---------------------");

            Console.WriteLine("Enter Your Designation :");
            des = Console.ReadLine();
            Console.WriteLine("---------------------");

            Console.WriteLine("Enter Your Emp_no :");
            emp_no = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");

            Console.WriteLine("Enter Your Basic_salary :");
            basic_salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");

            if (des == "manager")
                bonus = 0.55f * basic_salary;
            else if (des == "clerk")
                bonus = 0.25f * basic_salary;
            else if (des == "peun")
                bonus = 0.10f * basic_salary;
            else
                Console.WriteLine("invalid destination");

            total_salary = basic_salary + bonus;
            Console.WriteLine("---------------------");

            Console.WriteLine("Emp_name: {0} ,\n des: {1} ,\n emp_no:  {2},\n basic_salary: {3},\n total_salary: {4}",emp_name, des ,emp_no,basic_salary,total_salary);
            Console.ReadKey();






        }
    }
}
