using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidCastException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Rita");
            sb.Append("siya");
            sb.Append("kiya");
            Console.WriteLine("Sb:" + sb.ToString());
            object obj = sb;
            Console.WriteLine("object" + obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());

            }
            Console.ReadLine();
            Console.WriteLine("see you");
        }
    }
}
