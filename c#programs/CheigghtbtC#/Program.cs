using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheigghtbtC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("Enter height");
            height= Convert.ToInt32(Console.ReadLine());
            

            if (height<=135)
                Console.WriteLine("The person is Dwarf");
            else
                Console.WriteLine("The person is long");

            Console.ReadLine();
        }
    }
}
