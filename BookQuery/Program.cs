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

            Console.WriteLine("Enter Author(e.g. Ralls or Knorr, or Tim etc): ");
            string author = Console.ReadLine();
            Console.WriteLine("Books written by {0} are:", author);
            Console.WriteLine();
            Console.WriteLine("AUTHOR         TITLE              PRICE");
            Console.WriteLine("======   =================        =====");
            bool noneFound = true;
            foreach (Book x in books)
            {
                
                if (author.ToUpper() == x.Author.ToUpper())
                {
                    Console.WriteLine(x.ToString());
                    noneFound = false;
                }
            }
            if (noneFound)
            {
                Console.WriteLine("No such author fund!!");
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
