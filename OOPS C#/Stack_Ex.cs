using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push("A");
            st.Push("B");
            st.Push("C");
            st.Push("D");


            foreach(string str in st)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(                      );
            st.Push("V");
            st.Push("X");


            foreach (string str in st)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();

        }
    }
}
