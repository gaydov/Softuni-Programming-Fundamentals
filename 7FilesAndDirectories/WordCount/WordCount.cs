using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace WordCount
{
    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', '-', '_', '+', '\r', '\n' };
            string[] text = File.ReadAllText("text.txt").ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            if (File.Exists("results.txt"))
            {
                File.Delete("results.txt");
            }

            foreach (KeyValuePair<string, int> pair in wordsCount.OrderByDescending(p => p.Value))
            {
                File.AppendAllText("results.txt", string.Format("{0} - {1}{2}", pair.Key, pair.Value, Environment.NewLine));
            }
        }
    }
}
