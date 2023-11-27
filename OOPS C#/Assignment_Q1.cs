using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);

            foreach(object obj in arr)
            {
                Console.WriteLine("Number:"+obj);
            }
            Console.ReadLine();

        }
    }
}
