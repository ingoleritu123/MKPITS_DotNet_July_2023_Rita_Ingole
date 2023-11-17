using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exmultilavelinheritance
{
    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("barking");
        }
    }
    public class BabyDog : Dog
    {
        public void weep()
        {
            Console.WriteLine("weeping");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            BabyDog d1 = new BabyDog();
            d1.eat();
            d1.bark();
            d1.weep();
            Console.ReadLine();

        }
    }
}
