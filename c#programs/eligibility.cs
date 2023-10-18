using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibilitybyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter Your Age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
                Console.WriteLine("Congratulations You Are Eligible For Vote!!!");
            else
                Console.WriteLine("Sorry You Are Not Eligible For Vote!!! ");

            Console.ReadLine();
        }
    }
}
