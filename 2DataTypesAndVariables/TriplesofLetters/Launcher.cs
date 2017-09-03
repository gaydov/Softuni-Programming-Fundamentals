using System;

namespace TriplesofLetters
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int c1 = 0; c1 < n; c1++)
            {
                for (int c2 = 0; c2 < n; c2++)
                {
                    for (int c3 = 0; c3 < n; c3++)
                    {
                        char letter3 = (char)('a' + c3);
                        char letter2 = (char)('a' + c2);
                        char letter1 = (char)('a' + c1);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
                }
            }
        }
    }
}
