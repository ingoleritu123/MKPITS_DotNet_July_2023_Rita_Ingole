using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divof2nosinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            float div;
            Console.WriteLine("Enter 1st no:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd  no:");
            num2 = Convert.ToInt32(Console.ReadLine());
            div = num1/num2;
            Console.WriteLine("Division=" + div);
            Console.ReadLine();
        }
    }
}
