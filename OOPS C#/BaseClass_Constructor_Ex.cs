using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseclassConstructor_Ex
{
    class Company
    {
        public string name = "MKPIT";
        public Company()
        {
            Console.WriteLine("baseclass constructor:");
            Console.WriteLine("Company Name:" + name);

        }
    }
    class Frenchise : Company
    {
        public string name = "HCL";
        public Frenchise()
        {
            Console.WriteLine("derived class constructor:");
            Console.WriteLine("Frenchise:" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Frenchise f = new Frenchise();
            Console.ReadKey();
        }
    }
}
