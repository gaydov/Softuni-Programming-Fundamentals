using System;

namespace ReverseCharacters
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            char temp = letter3;
            letter3 = letter1;
            letter1 = temp;

            Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
        }
    }
}
