﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitinwordbyswitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter Character");
            num = Convert.ToInt32(Console.ReadLine();

            switch (num)
            {
                case '1':
                    Console.WriteLine("One");
                    break;
                case '2':
                    Console.WriteLine("Two");
                    break;
                case '3':
                    Console.WriteLine("Three");
                    break;
                case '4':
                    Console.WriteLine("Four");
                    break;
                case '5':
                    Console.WriteLine("Five");
                    break;


                default:
                    Console.WriteLine("invalid character");
                    break;
            }
            Console.ReadLine();
        }
    }
}
