using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.WriteLine("Enter value");
            m = Convert.ToInt32(Console.ReadLine());

            if (m<=0)
                Console.WriteLine("N=-1");
            else
                Console.WriteLine("N=1");

            Console.ReadLine();
        }
    }
}
