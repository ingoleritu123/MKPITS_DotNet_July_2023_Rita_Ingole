using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basekeyword_Ex
{
    class Animal
    {
        public string  color = "white";
    }
    class Dog : Animal
    {
        public string color = "red";
        public void  displaydata()
        {
            Console.WriteLine("Dog color:" + color);
            Console.WriteLine("Animal color:" + base.color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.displaydata();
            Console.ReadKey();
        }
    }
}
