using System;

namespace MelrahShake
{
    public class Launcher
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length != 0)
            {
                int firstMatchIndex = text.IndexOf(pattern);
                int lastMatchIndex = text.LastIndexOf(pattern);

                if (firstMatchIndex != -1 && lastMatchIndex != -1)
                {
                    text = text.Remove(firstMatchIndex, pattern.Length);
                    text = text.Remove(lastMatchIndex - pattern.Length, pattern.Length);
                    Console.WriteLine("Shaked it.");

                    int pattIndex = pattern.Length / 2;
                    pattern = pattern.Remove(pattIndex, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(text);
                    return;
                }
            }

            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
