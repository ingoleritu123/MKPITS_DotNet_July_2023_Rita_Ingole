using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptionhandling_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;

            Console.WriteLine("Enter number 1:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch(Exception ee)
            {
                Console.WriteLine("block executed");
                Console.WriteLine("cannot devided by zero");
            }
            finally
            {
                Console.WriteLine("finally block is executed :");
                Console.WriteLine("res=" + res);
            }
            Console.ReadLine();
        }
    }
}
