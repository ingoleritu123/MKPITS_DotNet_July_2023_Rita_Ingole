using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedAccessModifierEx2
{
    class protectedtest
    {
        protected string name = "rita";
        public void msg(string msg)
        {
            Console.WriteLine("hello" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            protectedtest p = new protectedtest();
            Console.WriteLine("hello" + protectedtest.name);//error show

            // Accessing protected function  
            protectedTest.Msg("Swami Ayyer");  //error

        }
    }
}
