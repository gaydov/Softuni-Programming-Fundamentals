using System;

namespace RandomizeWords
{
    public class Launcher
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split();
            Random randNum = new Random();
            int random = randNum.Next(words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                words[i] = words[random];
                words[random] = temp;
            }

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
