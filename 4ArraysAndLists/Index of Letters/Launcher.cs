using System;

namespace IndexofLetters
{
    public class IndexofLetters
    {
        public static void Main()
        {
            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }

            char[] input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                int alphabetIndex = 0;

                // For each of the letters in the input word we check every letter from the alphabet and if there is a match we print the respective index:
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        alphabetIndex = j;
                        break;
                    }
                }

                Console.WriteLine("{0} -> {1}", input[i], alphabetIndex);
            }
        }
    }
}
