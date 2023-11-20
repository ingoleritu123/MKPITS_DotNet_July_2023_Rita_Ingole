using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtimepoly_bydatamember_usingclassAnimal
{
    public class Animal
    {
        public string color = "White";
    }
    public class dog:Animal
    {
        public string color = "black";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Console.WriteLine(a.color);
            Console.ReadKey();
        }
    }
}
