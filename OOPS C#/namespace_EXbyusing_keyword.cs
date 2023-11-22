using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using Second;

namespace First
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello from 1st namespace:");
        }
    }
}
 

namespace Second
{
    public class welcome
    {
        public void saywelcome()
        {
            Console.WriteLine("Welcome from 2nd namespace:");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            hello h = new hello();
            h.sayhello();

            welcome w = new welcome();
            w.saywelcome();
            Console.ReadLine();
        }
    }
}
