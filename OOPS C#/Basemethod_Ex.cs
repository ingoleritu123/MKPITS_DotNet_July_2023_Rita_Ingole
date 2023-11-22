using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_method_Example
{
    class Company
    {
        public string name = "MKPIT";
        public void display()
        {
            Console.WriteLine("Company Name:" + name);
        }
    }
    class Frenchise : Company
    {
        public string name = "HCL";
        public void display()
        {
            base.display();
            Console.WriteLine("Frenchise:" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frenchise f = new Frenchise();
            f.display();
            Console.ReadLine();
        }
    }
}
