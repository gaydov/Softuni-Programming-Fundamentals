using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibraryModification
{
    public class Launcher
    {
        public static void Main()
        {
            int quantityBooks = int.Parse(Console.ReadLine());
            Library privateLibrary = new Library { Books = new List<Book>() };

            for (int bookIndex = 0; bookIndex < quantityBooks; bookIndex++)
            {
                string[] bookArgs = Console.ReadLine().Split();
                Book currentBook = new Book
                {
                    Title = bookArgs[0],
                    Author = bookArgs[1],
                    Publisher = bookArgs[2],
                    ReleaseDate = DateTime.ParseExact(bookArgs[3], "dd.MM.yyyy", null),
                    ISBN = bookArgs[4],
                    Price = double.Parse(bookArgs[5])
                };

                privateLibrary.Books.Add(currentBook);
            }

            DateTime afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            foreach (Book book in privateLibrary.Books
                .Where(b => b.ReleaseDate > afterDate)
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Title))
            {
                Console.WriteLine("{0} -> {1}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBN { get; set; }

        public double Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
