using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classbookwithmethodoverloding
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public void getdata()
        {
            bookid = 123;
            title = "RRR";
            author = "SSS";
            price = 230;
        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid,string title,string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
        }
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void displaydata()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata();
            b.displaydata();

            Book b1 = new Book();
            b1.getdata(111);
            b1.displaydata();

            Book b2 = new Book();
            b2.getdata(111, "csharp");
            b2.displaydata();


            Console.ReadKey();
        }
    }
}
