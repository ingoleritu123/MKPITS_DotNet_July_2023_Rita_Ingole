using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Bank
{
    interface bank
    {
        string deposite(int actno, int amt);
    }
    class saving : bank
    {
        int actno;
        int bal = 1000;
        public string deposite(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited successfully!! current Balance:" + bal;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bank b;
            b = new saving();
            string res= b.deposite(234,500);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
