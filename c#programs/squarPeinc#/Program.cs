﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squarPeinc_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num, square;
            Console.WriteLine("Enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("square =" + square);
            Console.ReadLine();

        }
    }
}
