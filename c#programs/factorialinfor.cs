using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialinfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int fact=1;

            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int counter=num; counter>0;counter--)
            {
                fact = fact * counter;
            }
            Console.WriteLine("factorial of " + num + "=" + fact);
            Console.ReadLine();
        }
    }
}
