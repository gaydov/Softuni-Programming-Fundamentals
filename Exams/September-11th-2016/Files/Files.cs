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
            Dictionary<string, Dictionary<string, int>> filesWithSizes = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < filesCount; i++)
            {
                string[] lineInput = Console.ReadLine().Split(';');
                string[] fileLocation = lineInput[0].Split('\\');
                string root = fileLocation[0];
                string file = fileLocation[fileLocation.Length - 1];
                int size = int.Parse(lineInput[1]);

                if (!filesWithSizes.ContainsKey(root))
                {
                    filesWithSizes.Add(root, new Dictionary<string, int>());
                    filesWithSizes[root][file] = size;
                }
                else
                {
                    filesWithSizes[root][file] = size;
                }
            }

            string[] queryArgs = Console.ReadLine().Split();
            string extension = queryArgs[0];
            string rootDir = queryArgs[queryArgs.Length - 1];

            // We check if the directory exists in the dictionary:
            if (filesWithSizes.ContainsKey(rootDir))
            {
                var resultCollection = filesWithSizes[rootDir].Where(p => p.Key.EndsWith(extension)).OrderByDescending(p => p.Value).ThenBy(p => p.Key);

                // We check if there is at least 1 file that match our query:
                if (resultCollection.Count() > 0)
                {
                    foreach (KeyValuePair<string, int> file in resultCollection)
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
