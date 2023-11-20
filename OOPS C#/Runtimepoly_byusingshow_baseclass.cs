using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtimepolymorphism_Exby_Showbaseclass
{
    class Baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("hello");
        }
    }
    class  Childclass:Baseclass
    {
        public override void show()
        {
            Console.WriteLine("Childclass");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Baseclass b = new Baseclass();
            b.show();
            Console.ReadLine();
        }
    }
}
