using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    public class Launcher
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            bool result = AreTwoStringsExchangeable(input);
            Console.WriteLine(result.ToString().ToLower());
        }

        public static bool AreTwoStringsExchangeable(string[] input)
        {
            string firstStr = input[0];
            string secondStr = input[1];
            string shorter = string.Empty;
            string longer = string.Empty;

            if (firstStr.Length <= secondStr.Length)
            {
                shorter = firstStr;
                longer = secondStr;
            }
            else
            {
                shorter = secondStr;
                longer = firstStr;
            }

            Dictionary<char, char> mappings = new Dictionary<char, char>();
            int length = Math.Min(firstStr.Length, secondStr.Length);
            bool areExchangeable = true;

            // Iterating the two strings until the shorter one's length is reached:
            for (int i = 0; i < length; i++)
            {
                if (!mappings.ContainsKey(firstStr[i]) && !mappings.ContainsValue(secondStr[i]))
                {
                    mappings[firstStr[i]] = secondStr[i];
                }
                else
                {
                    // If there is such key we check if the corresponding value isn't different:
                    if (mappings.ContainsKey(firstStr[i]))
                    {
                        if (mappings[firstStr[i]] != secondStr[i])
                        {
                            areExchangeable = false;
                            return areExchangeable;
                        }
                    }
                    else if (mappings.ContainsValue(secondStr[i]))
                    {
                        // There is already such key with its value so if the current char matches any value from the dictionary the strings aren't exchangeable:
                        areExchangeable = false;
                        return areExchangeable;
                    }
                }
            }

            // If one of the strings is longer than the other we must check the additional letters:
            string remainingLetters = longer.Substring(length);

            foreach (char letter in remainingLetters)
            {
                if (!mappings.ContainsKey(letter) && !mappings.ContainsValue(letter))
                {
                    areExchangeable = false;
                    return areExchangeable;
                }
            }

            return areExchangeable;
        }
    }
}
