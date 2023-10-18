using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vovels_conC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("Enter charecter");
            ch = Console.ReadLine();

            if (ch == "a" || ch == "e" || ch == "i" || ch == "o" || ch == "u")

            {
                Console.WriteLine("is a vovel");
            }
            else
                Console.WriteLine( "is a consonent");

            Console.ReadLine();
           
             

        }
    }
}
