using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avarageinC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, ava;
            Console.WriteLine("Enter 1st No :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd No :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd No :");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 4th No :");
            num4 = Convert.ToInt32(Console.ReadLine());
            ava = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("Avarage of " + num1+","+num2+","+num3+","+num4+"= " +ava);
            Console.ReadLine();
        }
    }
}
