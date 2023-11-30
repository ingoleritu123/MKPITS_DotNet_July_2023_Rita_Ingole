using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutOfMemoryException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "bobby";
            string subject = "Mathemathics";
            Console.WriteLine("length of Name:" + Name.Length);
            StringBuilder sb = new StringBuilder(Name.Length,Name.Length);
            try
            {
                sb.Append(subject);
            }

            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.ReadLine();
        }
    }
}
