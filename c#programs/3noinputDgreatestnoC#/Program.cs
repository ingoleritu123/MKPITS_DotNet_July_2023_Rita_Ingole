using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3noinputDgreatestnoC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1>num3)
                Console.WriteLine(num1 + " is a greater");

            else if (num2 > num3 && num2>num1)
                Console.WriteLine(num2 + " is a greater");
            else
                Console.WriteLine(num3 + "is greater");

            Console.ReadLine();
        }
    }
}
