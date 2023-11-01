using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradeinSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Enter Character");
            ch = Convert.ToChar(Console.ReadLine();

            switch(ch)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Avarage");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;


                default:
                    Console.WriteLine("invalid character");
                    break;
            }
            Console.ReadLine();
        }
    }
}
