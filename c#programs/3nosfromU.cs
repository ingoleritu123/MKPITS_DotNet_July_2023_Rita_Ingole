using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _3nosfromUbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3,add,tadd;
            Console.WriteLine("Enter 1st No");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd No");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter3rd No");
            num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entered 3 No's = "+ num1+"," +","+ num2+"," + num3);
            add = (num1 + num2) * num3;
            Console.WriteLine("(x+y).z= " + add);
            tadd=(num1*num2)+(num2*num3);
            Console.WriteLine("(x*y)+(y*z) =" + tadd);


            Console.ReadLine();

        }
    }
}
