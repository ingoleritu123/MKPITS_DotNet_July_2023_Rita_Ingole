using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areainC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len , bre , area;
            Console.WriteLine("Enter length:");
            len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth:");
            bre = Convert.ToInt32(Console.ReadLine());
            area = len*bre;+
            Console.WriteLine("area =" + area);
            Console.ReadLine();
        }
    }
}
