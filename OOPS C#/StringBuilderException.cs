using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Rita");
            sb.Append("kiya");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("see you");
            Console.ReadLine();
        }
    }
}
