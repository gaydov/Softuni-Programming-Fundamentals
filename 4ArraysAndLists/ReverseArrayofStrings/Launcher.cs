using System;

namespace ReverseArrayofStrings
{
    public class Launcher
    {
        public static void Main()
        {
            string[] strArr = Console.ReadLine().Split();

            string[] reversedArr = new string[strArr.Length];

            for (int i = 0; i < strArr.Length; i++)
            {
                reversedArr[i] = strArr[strArr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", reversedArr));
        }
    }
}
