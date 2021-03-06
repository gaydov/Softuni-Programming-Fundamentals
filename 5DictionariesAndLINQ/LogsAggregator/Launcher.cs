﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LogsAggregator
{
    public class Launcher
    {
        public static void Main()
        {
            int recordsCount = int.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> database = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < recordsCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string ipAddress = input[0];
                string userName = input[1];
                int duration = int.Parse(input[2]);

                if (!database.ContainsKey(userName))
                {
                    database.Add(userName, new SortedDictionary<string, int>());
                    database[userName].Add(ipAddress, duration);
                }
                else
                {
                    if (!database[userName].ContainsKey(ipAddress))
                    {
                        database[userName].Add(ipAddress, duration);
                    }
                    else
                    {
                        database[userName][ipAddress] += duration;
                    }
                }
            }

            GetUsersIPsAndSessionDuration(database);
        }

        public static void GetUsersIPsAndSessionDuration(SortedDictionary<string, SortedDictionary<string, int>> database)
        {
            foreach (string user in database.Keys)
            {
                int totalDuration = database[user].Values.Sum();
                List<string> ipAddresses = database[user].Keys.ToList();

                Console.WriteLine("{0}: {1} [{2}] ", user, totalDuration, string.Join(", ", ipAddresses));
            }
        }
    }
}
