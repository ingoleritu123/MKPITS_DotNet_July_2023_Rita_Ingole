using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divideByZeroException
{
    class Divide
    {
        int result = 0;

        public Divide()
        {
            result = 0;
        }
        public void Division(int num1,int num2)
        
        {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Exception"+ex);
            }
            finally
            {
                Console.WriteLine("Finally Code is executed");
                Console.WriteLine("result"+result);
            }
            Console.WriteLine("bye");
            
           
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Divide d = new Divide();
            d.Division(25, 0);
            Console.ReadKey();

        }
    }
}
