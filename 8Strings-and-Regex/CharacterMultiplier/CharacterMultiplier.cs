using System;

namespace CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int product = CharMultiplier(input);
            Console.WriteLine(product);
        }

        public static int CharMultiplier(string inputString)
        {
            string[] strings = inputString.Split();
            string firstString = strings[0];
            string secondString = strings[1];
            int length = Math.Max(firstString.Length, secondString.Length);
            int result = 0;

            for (int i = 0; i < length; i++)
            {
                int firstStrCharASCIIcode = 1;
                int secondStrCharASCIIcode = 1;

                if (i < firstString.Length)
                {
                    firstStrCharASCIIcode = firstString[i];
                }

                if (i < secondString.Length)
                {
                    secondStrCharASCIIcode = secondString[i];
                }

                result += firstStrCharASCIIcode * secondStrCharASCIIcode;
            }

            return result;
        }
    }
}
