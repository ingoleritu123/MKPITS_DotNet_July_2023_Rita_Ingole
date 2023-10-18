using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ve__venobyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
                Console.WriteLine(num + "is a positive no");
            else
                Console.WriteLine(num + "is a negative no");
        }
    }
}
