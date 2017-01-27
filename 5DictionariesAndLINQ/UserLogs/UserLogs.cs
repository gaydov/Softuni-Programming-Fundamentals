using System;
using System.Collections.Generic;

namespace UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> database = new SortedDictionary<string, Dictionary<string, int>>();
            string[] input = Console.ReadLine().Split(new string[] { "=", " " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> IPsWithCounts = new Dictionary<string, int>();

            while (!input[0].Equals("end"))
            {
                string IP = input[1];
                string user = input[input.Length - 1];

                if (!database.ContainsKey(user))
                {
                    database.Add(user, new Dictionary<string, int>());
                    database[user].Add(IP, 1);
                }
                else
                {
                    if (!database[user].ContainsKey(IP))
                    {
                        database[user].Add(IP, 1);
                    }
                    else
                    {
                        database[user][IP]++;
                    }
                }

                input = Console.ReadLine().Split(new string[] { "=", " " }, StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (string userName in database.Keys)
            {
                Console.WriteLine("{0}: ", userName);

                int count = database[userName].Count;

                foreach (string IPaddress in database[userName].Keys)
                {
                    if (count > 1)
                    {
                        Console.Write("{0} => {1}, ", IPaddress, database[userName][IPaddress]);
                    }
                    else
                    {
                        Console.WriteLine("{0} => {1}. ", IPaddress, database[userName][IPaddress]);
                    }
                    count--;
                }
            }
        }
    }
}
