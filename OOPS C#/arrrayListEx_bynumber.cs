using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList_Ex_bynumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(123);
            arr.Add(345);
            arr.Add(346);

            foreach(object ob in arr)
            {
                Console.WriteLine("Number:" + ob);
            }
            Console.WriteLine("capacity:" + arr.Capacity);
            Console.WriteLine("Count:" + arr.Count);
            Console.ReadLine();

        }
    }
}
