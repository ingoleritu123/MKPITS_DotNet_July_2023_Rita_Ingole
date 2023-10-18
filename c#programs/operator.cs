using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatorbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, add, sub, mal, div,result=0;
            string op;

            Console.WriteLine("Enter first no");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second no");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Operator no");
            op = Console.ReadLine();



            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;

            Console.WriteLine("Result:" + result);
            Console.ReadLine();


        }
    }
}
