using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calExinmethodoverlodwithdiffpara
{
    class Calculate
    {
        public void addition(int num1,int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Addition of int is:" + res);8


        }
        public void addition(float num1,float num2)
        {
            float res = num1 + num2;
            Console.WriteLine("Addition of float is:" + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.addition(1, 2);
            Console.WriteLine("disply res of float");
            calc.addition(1.5f, 3.6f);
            Console.ReadKey();
        }
    }
}
