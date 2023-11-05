using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace localvariable
{
    internal class Program
    {
        static int num = 20;
        static void display()
        {
            int num = 10;
            Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            display();
            Console.WriteLine("num" + num);
            Console.ReadKey();
        }
    }
}
