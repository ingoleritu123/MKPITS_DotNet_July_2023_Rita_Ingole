using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageinputbyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are older than " + age);
            Console.ReadLine();
        }
    }
}
