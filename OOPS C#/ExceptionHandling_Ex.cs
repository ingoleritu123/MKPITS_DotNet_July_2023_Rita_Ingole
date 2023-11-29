using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter Number:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2:");
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch(Exception ee)
            {
                Console.WriteLine("Cannot devide by zero");
            }
            Console.WriteLine("res=" + res);
            Console.WriteLine("bye");
            Console.ReadLine();
        }
    }
}
