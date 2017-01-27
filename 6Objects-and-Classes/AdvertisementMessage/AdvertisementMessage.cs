using System;

namespace AdvertisementMessage
{
    public class AdvertisementMessage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                string randomPhrase = phrases[rand.Next(phrases.Length)];
                string randomEvent = events[rand.Next(events.Length)];
                string randomAuthor = authors[rand.Next(authors.Length)];
                string randomCity = cities[rand.Next(cities.Length)];

                Console.WriteLine("{0} {1} {2} - {3}", randomPhrase, randomEvent, randomAuthor, randomCity);
            }
        }
    }
}
