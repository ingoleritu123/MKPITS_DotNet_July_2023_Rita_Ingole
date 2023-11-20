using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_Ex_byusingClassAnimal
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
       public override void eat()
        {
            Console.WriteLine("Eating a bread");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.eat();
            Console.ReadKey();

        }
    }
}
