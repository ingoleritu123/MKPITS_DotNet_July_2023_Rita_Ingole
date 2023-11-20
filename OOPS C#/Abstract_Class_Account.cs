using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Account
{
    abstract class Account
    {
        public abstract void deposit();
     
    }
     class saving : Account
    {
        public override void deposit()
        {
            Console.WriteLine("hello from saving");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
                
                
                Account act = new saving();
            act.deposit();

        }
    }
}
