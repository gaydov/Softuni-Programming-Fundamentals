using System;
using System.Collections.Generic;

namespace LettersChangeNumbers
{
    public class LettersChangeNumbers
    {
        public static void Main()
        {
            Dictionary<char, int> upperCaseAlphabet = new Dictionary<char, int>();
            Dictionary<char, int> lowerCaseAlphabet = new Dictionary<char, int>();
            GeneratingAlphabets(upperCaseAlphabet, lowerCaseAlphabet);
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            foreach (string expression in input)
            {
                char[] firstLetter = expression.Substring(0, 1).ToCharArray();
                double number = int.Parse(expression.Substring(1, expression.Length - 2));
                char[] lastLetter = expression.Substring(expression.Length - 1).ToCharArray();

                double currentResult = 0;

                if (upperCaseAlphabet.ContainsKey(firstLetter[0]))
                {
                    currentResult = number / upperCaseAlphabet[firstLetter[0]];
                }
                if (lowerCaseAlphabet.ContainsKey(firstLetter[0]))
                {
                    currentResult = number * lowerCaseAlphabet[firstLetter[0]];
                }
                if (upperCaseAlphabet.ContainsKey(lastLetter[0]))
                {
                    currentResult -= upperCaseAlphabet[lastLetter[0]];
                }
                if (lowerCaseAlphabet.ContainsKey(lastLetter[0]))
                {
                    currentResult += lowerCaseAlphabet[lastLetter[0]];
                }

                totalSum += currentResult;
            }

            Console.WriteLine(totalSum.ToString(format: "0.00"));
        }

        public static void GeneratingAlphabets(Dictionary<char, int> alphabetCapitals, Dictionary<char, int> alphabetNonCapitals)
        {
            int position = 1;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                alphabetCapitals[i] = position;
                position++;
            }

            position = 1;
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabetNonCapitals[i] = position;
                position++;
            }
        }
    }
}
