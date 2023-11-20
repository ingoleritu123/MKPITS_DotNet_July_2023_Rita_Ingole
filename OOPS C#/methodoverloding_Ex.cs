using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverloading_Ex
{
    class book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 23;
            title = "Rich Dad Poor Dad";
            author = "Robort Kiyosaki";
            price = 100;
        }
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("BookId:" + bookid);
            Console.WriteLine("title:" + title);
            Console.WriteLine("Author:" + author);
            Console.WriteLine("price:" + price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b1 = new book();
            b1.getdata();
            b1.display();

            Console.WriteLine("----Book1 Details----");
            book b2 = new book();
            b2.getdata(123, "Csharp", "akash", 200);
            b2.display();

            Console.WriteLine("-----------------book1 details ----------");
            Console.WriteLine("enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            String title = Console.ReadLine();
            Console.WriteLine("enter author");
            String author = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------book2 details ----------");
            book b3 = new book();
            b2.getdata(id, title, author, price);
            b2.display();


        }
    }
}
