using System;

namespace NumbersinReversedOrder
{
    public class Launcher
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        public static void ReverseNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }

            Console.WriteLine();
        }
    }
}
