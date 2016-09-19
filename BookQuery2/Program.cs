using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = {
            new Book("Midnight Rain" ,"Ralls" , 44.95),
            new Book("Maeve Ascendant", "Ralls", 5.95),
            new Book("Oberon's Legacy", "Knorr", 4.95),
            new Book("The Sundered Grail", "Knorr", 9.95),
            new Book("Lover Birds", "Knorr", 8.95),
            new Book("Splish Splash", "Tim", 4.95),
            new Book("Creepy Crawlies", "Tim", 14.95),
            new Book("Paradox Los", "Tim", 14.95)
        };
 //sort array of obj by one of prop of each obj: First sort by title & then group by Author:
//lambda expressions & anonymous methods: sSBS-468 (ch-20 starts at p-451)
//x => x+1; says "given x, return x+1"
//http://stackoverflow.com/questions/290061/what-does-the-syntax-in-c-sharp-mean
//expanded form: http://www.csharp-examples.net/sort-array/
            Array.Sort(books, (x, y) => String.Compare(x.Title, y.Title));
            Array.Sort(books, (x, y) => String.Compare(x.Author, y.Author));

            //Console.WriteLine("Enter Author(e.g. Ralls or Knorr, or Tim etc): ");
            //string author = Console.ReadLine();
            Console.WriteLine("Books written by {0} are:");
            Console.WriteLine();
            Console.WriteLine("AUTHOR         TITLE              PRICE");
            Console.WriteLine("======   =================        =====");
            //bool noneFound = true;
            foreach (Book x in books)
            {

                Console.WriteLine(x.ToString());

            }


        }
    }

    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public double Price { get; private set; }

        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }
        public override string ToString()
        {
            return string.Format("{0, -9}{1, -20}{2, 10:c}", Author, Title, Price);
        }
    }
}
