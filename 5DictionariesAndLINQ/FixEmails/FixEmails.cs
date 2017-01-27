using System;
using System.Collections.Generic;
using System.Linq;

namespace FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
            Dictionary<string, string> database = new Dictionary<string, string>();
            string name = Console.ReadLine();

            while (!name.Equals("stop"))
            {
                string inputEmail = Console.ReadLine();
                database.Add(name, inputEmail);
                name = Console.ReadLine();
            }

            string[] domains = { ".uk", ".us" };

            foreach (string domain in domains)
            {
                List<KeyValuePair<string, string>> filteredDatabase = database.Where(x => x.Value.EndsWith(domain)).ToList();
                foreach (KeyValuePair<string, string> entry in filteredDatabase)
                {
                    database.Remove(entry.Key); 
                }
            }

            foreach (KeyValuePair<string, string> entry in database)
            {
                Console.WriteLine("{0} -> {1}", entry.Key, entry.Value);
            }
        }
    }
}
