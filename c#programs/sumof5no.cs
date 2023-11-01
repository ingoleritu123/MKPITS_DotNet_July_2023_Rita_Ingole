using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumof5nosbyfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum=0;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.WriteLine("Enter number:");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum of 5 nos is =" + sum);
            Console.ReadLine();
        }
    }
}
