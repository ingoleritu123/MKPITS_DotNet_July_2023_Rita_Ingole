using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mulof3nosbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, mal;
            Console.WriteLine("Enter 1st no:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd  no:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rdd  no:");
            num3 = Convert.ToInt32(Console.ReadLine());
            mal = num1 * num2 * num3;
            Console.WriteLine("multiplicayion 0f :" + num1 + "*" + num2 + "*" + num3 + "=" + mal);
            Console.ReadLine();
        }
    }
}
