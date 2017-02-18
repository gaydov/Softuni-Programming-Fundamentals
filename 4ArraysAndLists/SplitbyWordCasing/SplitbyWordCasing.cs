using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitbyWordCasing
{
    public class SplitbyWordCasing
    {
        public static void Main()
        {
            char[] delimiters = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> input = Console.ReadLine().Split(delimiters).ToList();

            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();

            foreach (string word in input)
            {
                if (word.Equals(string.Empty))
                {
                    continue;
                }

                int lowerSum = 0;
                int upperSum = 0;

                foreach (char letter in word)
                {

                    if (letter >= 'a' && letter <= 'z')
                    {
                        lowerSum++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        upperSum++;
                    }
                    else
                    {
                        // If the letter is not lower or upper case then we assign to the sums value of 1 in order the word to go to the mixed list:
                        lowerSum = 1;
                        upperSum = 1;
                    }
                }

                if (lowerSum == 0)
                {
                    upperCase.Add(word);
                }
                else if (upperSum == 0)
                {
                    lowerCase.Add(word);
                }
                else
                {
                    mixed.Add(word);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixed));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
