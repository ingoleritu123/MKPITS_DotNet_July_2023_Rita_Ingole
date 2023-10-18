using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableofNbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i, result;
            Console.WriteLine("Enter a Number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1;i<= 10; i++) 
            {
                result = num * i;
                Console.WriteLine(num + "*" + i+"=" + result);
            }
            Console.ReadLine();
        }
    }
}
