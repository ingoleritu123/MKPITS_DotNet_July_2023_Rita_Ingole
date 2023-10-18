using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadrantnamebyC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter value of x");
            x = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter value of y");
            y = Convert.ToInt32(Console.ReadLine());


            if (x > 0 && y > 0)
                Console.WriteLine("The co-ordinate point" + x + "," + y + " lies in the First quadrant");
            if (x > 0 && y < 0)
                Console.WriteLine("The co-ordinate point" + x + "," + y + " lies in the Second quadrant");
            if (x < 0 && y < 0)
                Console.WriteLine("The co-ordinate point" + x + "," + y + " lies in the third quadrant");
            if (x < 0 && y > 0)
                Console.WriteLine("The co-ordinate point" + x + "," + y + " lies in the Fourth quadrant");

            Console.ReadLine();

        }
    }
}
