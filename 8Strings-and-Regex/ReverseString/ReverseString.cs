using System;
using System.Linq;

namespace ReverseString
{
    public class ReverseString
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Console.WriteLine(string.Join("", input.Reverse()));
        }
    }
}
