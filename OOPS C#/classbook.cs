using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classboookC_
{
    internal class Program
    {
        class Book
        {
            string title;
            string author;
            int publicationYear;
         public void getdata(string title, string author, int publicationyear)
            {
                this.title = title;
                this.author = author;
                this.publicationYear = publicationyear;
            }
            public void displaydata()
            {
                Console.WriteLine("Author :" + author);
                Console.WriteLine("title :" + title);
                Console.WriteLine("publicationyear : " + publicationYear);

            }
        }
        static void Main(string[] args)
        {
            Book[] bookied = new Book[3];

            bookied[0] = new Book();
            bookied[1] = new Book();
            bookied[2] = new Book();
            string auth = null;
            string tit = null;
            int publication = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Author:");
                auth = Console.ReadLine();

                Console.WriteLine("Enter title:");
                tit = Console.ReadLine();

                Console.WriteLine("Enter publicationYear:");
                publication = Convert.ToInt32(Console.ReadLine());
                bookied[i].getdata(auth, tit, publication);
            }

            for (int i = 0; i < 3; i++)
            {
                bookied[i].displaydata();

            }
            Console.ReadKey();


        }
    }
}
