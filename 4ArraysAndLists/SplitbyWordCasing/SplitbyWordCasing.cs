using System;
using System.Collections.Generic;
using System.Linq;

namespace SplitbyWordCasing
{
    public class SplitbyWordCasing
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split(',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ').ToList();
            List<string> lowerCase = new List<string>();
            List<string> upperCase = new List<string>();
            List<string> mixed = new List<string>();

            foreach (string word in input)
            {
                if (word == string.Empty)
                {
                    continue;
                }

                int sumLower = 0;
                int sumUpper = 0;

                foreach (char letter in word)
                {

                    if (letter >= 'a' && letter <= 'z')
                    {
                        sumLower++;
                    }
                    else if (letter >= 'A' && letter <= 'Z')
                    {
                        sumUpper++;
                    }
                    else
                    {
                        // If the letter is not lower or upper case then we assign to the sums value of 1 in order the word to go to the mixed list:
                        sumLower = 1;
                        sumUpper = 1;
                    }
                }

                if (sumLower == 0)
                {
                    upperCase.Add(word);
                }
                else if (sumUpper == 0)
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
