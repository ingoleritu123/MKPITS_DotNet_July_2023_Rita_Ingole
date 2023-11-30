using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOutOfRangeException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            try
            {
                for (int i = 0; i <= 3; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine("FInally Code is excuted");
            }
            Console.ReadKey();
        }
    }
}
