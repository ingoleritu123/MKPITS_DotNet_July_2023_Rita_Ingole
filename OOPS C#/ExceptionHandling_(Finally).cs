using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling__Finally_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter 1st number:");
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
                Console.WriteLine("Block is executing");
                Console.WriteLine("Cannot Devided ");
            }

            finally
            {
                Console.WriteLine("Finally block is executing");
                Console.WriteLine("res:" + res);
            }

        }
    }
}
