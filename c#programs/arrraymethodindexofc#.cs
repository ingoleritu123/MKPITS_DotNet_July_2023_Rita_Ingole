﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraymethodIndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 3 };
            int l = Array.IndexOf(arr, 5);
            Console.WriteLine("Index of 5 is:" + l);
            Console.ReadKey();
        }
    }
}
