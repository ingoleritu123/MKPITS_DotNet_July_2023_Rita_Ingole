using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenoddbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,i;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (i%2==0)
                Console.WriteLine("It is an even no");
            else
                Console.WriteLine("It is an odd no");

            Console.ReadLine();
        }
    }
}
