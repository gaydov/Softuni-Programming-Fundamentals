using System;
using System.Collections.Generic;
using System.Linq;

namespace Files
{
    public class Files
    {
        public static void Main()
        {
            int filesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < filesCount; i++)
            {
                string[] dirAndSize = Console.ReadLine().Split(';');
                long size = long.Parse(dirAndSize[1]);
                string[] fullDir = dirAndSize[0].Split('\\');
                string mainDir = fullDir[0];
                string fileName = fullDir.Last();

                if (!database.ContainsKey(mainDir))
                {
                    database.Add(mainDir, new Dictionary<string, long>());
                    database[mainDir][fileName] = size;
                }
                else
                {
                    database[mainDir][fileName] = size;
                }
            }

            string[] filterArgs = Console.ReadLine().Split();
            string extension = filterArgs[0];
            string directory = filterArgs[2];

            if (database.ContainsKey(directory))
            {
                var queryResults = database[directory].Where(p => p.Key.EndsWith(extension)).OrderByDescending(p => p.Value).ThenBy(p => p.Key);

                if (queryResults.Count() > 0)
                {
                    foreach (var file in queryResults)
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");
                    }
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
