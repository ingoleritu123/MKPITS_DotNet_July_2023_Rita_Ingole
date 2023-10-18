using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter Year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
                Console.WriteLine("It is leap year");
            else
                Console.WriteLine("It is not leap year");

            Console.ReadLine();

        }
    }
}
