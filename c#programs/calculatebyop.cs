using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatebyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, add, sub, div, mal,mod;
            Console.WriteLine("Enter 1st NO");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd NO");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            mal = num1 * num2;
            div = num1 / num2;
            mod = num1 % num2;
            Console.WriteLine(num1 + "+" + num2 + "= " + add);
            Console.WriteLine(num1 + "-" + num2 + "= " + sub);
            Console.WriteLine(num1 + "*" + num2 + "= " + mal);
            Console.WriteLine(num1 + "/" + num2 + "= " + div);
            Console.WriteLine(num1+ "mod"+ num2 +"=" + mod);
            Console.ReadLine();



        }
    }
}
