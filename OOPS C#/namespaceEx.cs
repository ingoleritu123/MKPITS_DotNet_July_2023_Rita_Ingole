using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("hello from firstnamespace");
        }
    }

    namespace Second
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("hello from Secondnamespace");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                First.Hello h = new First.Hello();
                Second.Hello h1 = new Second.Hello();
                h.sayHello();
                h1.sayHello();
                Console.ReadKey();
            }
        }
    }
}
