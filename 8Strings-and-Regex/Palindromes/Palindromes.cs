using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindromes
{
    public class Palindromes
    {
        public static void Main()
        {
            char[] delimiters = { ' ', ',', '.', '?', '!' };
            string[] input = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();

            foreach (string word in input)
            {
                char[] currentWord = word.ToCharArray();
                char[] wordReversed = word.ToCharArray();
                Array.Reverse(wordReversed);

                string currentWordStr = string.Join("", currentWord);
                string wordReversedStr = string.Join("", wordReversed);

                if(currentWordStr.Equals(wordReversedStr))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(p => p)));
        }
    }
}
