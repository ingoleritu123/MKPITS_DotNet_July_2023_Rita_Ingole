using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circuminc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circum;
            Console.WriteLine("Enter radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            circum = 2 * 3.14f * radius;
            area = 3.14f * radius * radius;
            Console.WriteLine("area of a circle  = " + area);
            Console.WriteLine("circumfarace of circle = " + circum);
            Console.ReadLine();
        }
    }
}
