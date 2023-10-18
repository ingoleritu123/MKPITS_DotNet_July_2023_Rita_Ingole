using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace profit_lossC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s, c,total;
            Console.WriteLine("Enter a selling Price");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Cost Price");
            c = Convert.ToInt32(Console.ReadLine());

            total = c - s;


            if (s > c)
                Console.WriteLine("you got profit of"+total);
            else
                Console.WriteLine("You got loss of" + total);

            Console.ReadLine();
            
            
        }
    }
}
