using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkequalnobyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter 1st no");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd no");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
                Console.WriteLine("Number is Equal");
            else
                Console.WriteLine("Number is not Equal");

            Console.ReadLine();

        }
    }
}
