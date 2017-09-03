using System;
using System.Collections.Generic;
using System.Linq;

namespace BookLibrary
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

            Dictionary<string, double> authorsWithBooks = new Dictionary<string, double>();

            foreach (Book book in privateLibrary.Books)
            {
                if (!authorsWithBooks.ContainsKey(book.Author))
                {
                    authorsWithBooks.Add(book.Author, book.Price);
                }
                else
                {
                    authorsWithBooks[book.Author] += book.Price;
                }
            }

            foreach (KeyValuePair<string, double> entry in authorsWithBooks.OrderByDescending(b => b.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:F2}", entry.Key, entry.Value);
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
}
