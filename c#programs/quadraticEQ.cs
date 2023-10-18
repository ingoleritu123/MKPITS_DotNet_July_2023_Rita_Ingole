using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadraticEqbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, C,total;
            Console.WriteLine("Enter a value of a");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value of b");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value of c");
            C= Convert.ToInt32(Console.ReadLine());

            total = b * b + 4 * a * C;

            if (total!=0)
                Console.WriteLine("it is imaginary root");
            else
                Console.WriteLine("it is real root");


            Console.ReadLine();


        }
    }
}
