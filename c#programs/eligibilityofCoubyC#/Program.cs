using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eligibilityofCoubyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, p, c, total;
            Console.WriteLine("Enter maks of Maths");
            m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maks of Physics");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter maks of Chemistry");
            c = Convert.ToInt32(Console.ReadLine());

            total = m + p + c;

            if (total >= 180)
                Console.WriteLine("Eligible");
            else
                Console.WriteLine("not eligible");

            Console.ReadLine();
        }
    }
}
