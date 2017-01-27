using System;

namespace VowelorDigit
{
    public class VowelorDigit
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            // creating switch to check all the possible variants:
            switch (input)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i':
                    Console.WriteLine("vowel");
                    break;

                default:

                    if (Char.IsDigit(input))
                    {
                        Console.WriteLine("digit");
                    }
                    else
                    {
                        Console.WriteLine("other");
                    }

                    break;
            }
        }
    }
}
