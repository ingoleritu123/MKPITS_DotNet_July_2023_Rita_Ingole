using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceBankwithclass_Saving_Current
{
    interface bank
    {
        string deposit(int actno, int amt);

    }
    class saving: bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Account_No:" + actno + "\n" + "balance is:" + bal;
        }
    }
    class current : bank
    {
        int actno;
        int bal = 1000;
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "Account_No:" + actno + "\n" + "balance is:" + bal;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            bank b = null;
            Console.WriteLine("enter saving or current");
            string acttype = Console.ReadLine();
            switch (acttype)
            {
                case "saving":
                    b = new saving();
                    break;
                case "current":
                    b = new current();
                    break;

            }
            string res = b.deposit(1, 700);
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
