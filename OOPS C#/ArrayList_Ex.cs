using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArryList_Ex
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add("Amit");
            arr.Add("Amita");
            arr.Add("Amiti");

            foreach(object obj in arr)
            {
                Console.WriteLine("Student Name:"+obj);
            }
            Console.ReadLine();
        }
    }
}
