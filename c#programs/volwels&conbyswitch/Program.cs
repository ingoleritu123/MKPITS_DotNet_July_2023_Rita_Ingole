using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volwels_conbyswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter a character");
            ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine(ch + "is vowel.");
                    break;
                default:
                    Console.WriteLine(ch + "it is consonent.");
                    break;



            }
            Console.ReadLine();

        }
    }
}
