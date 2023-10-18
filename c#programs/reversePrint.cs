using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseprintbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a,b,c;
            Console.WriteLine("Enter first Latter");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter 2nd Latter");
            b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter 3rd Latter ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Reverse printing");
            Console.WriteLine(c + " " + b + " " +  a);
            Console.ReadLine();

        }
    }
}
