using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticfildbook_constructor
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine("static field constractor called");
            title = "title";

        }
        public void display()
        {

            Console.WriteLine("title : " + title);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book();
            b1.display();
            book b2 = new book();
            b2.display();
            Console.ReadKey();

        }
    }
}
