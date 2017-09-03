using System;
using System.Linq;

namespace ReverseString
{
    public class Launcher
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine(string.Join(string.Empty, input.Reverse()));
        }
    }
}
