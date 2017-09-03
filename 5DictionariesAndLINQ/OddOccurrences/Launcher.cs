using System;
using System.Collections.Generic;

namespace OddOccurrences
{
    public class Launcher
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();
            
            foreach (string item in input)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words[item] = 1;
                }
            }

            List<string> results = new List<string>();

            foreach (string word in words.Keys)
            {
                if (words[word] % 2 != 0)
                {
                    results.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
