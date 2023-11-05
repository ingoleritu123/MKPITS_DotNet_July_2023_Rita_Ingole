using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boookconstructor
{
    internal class Program
    {
        class Book
        {
           int BookId;
            string title, author;

            public Book()
            {
                BookId = 123;
                title = "rich dad poor dad";
                author = "kiyosaki";

            }
            public void display()
            {
                Console.WriteLine("BookId:" + BookId);
                Console.WriteLine("Title:" + title);
                Console.WriteLine("Author:" + author);
            }

        }
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadLine();


        }
    }
}
