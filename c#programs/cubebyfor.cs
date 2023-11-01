using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubebyfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int result=0;
            Console.WriteLine("Enter number:");
            num = Convert.ToInt32(Console.ReadLine());
            for(int cnt=1;cnt<=num;cnt++)
            {
                result =cnt*cnt*cnt;
                Console.WriteLine("number is {0} and cube of the {1} is {2}", cnt, cnt, result);
               
            }
            Console.ReadLine();
        }
    }
}
