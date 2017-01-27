using System;

namespace NumbersinReversedOrder
{
    public class NumbersinReversedOrder
    {
        public static void Main()
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        private static void ReverseNumber(string num)
        {
            for (int i = num.Length - 1; i >= 0; i--)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
        }
    }
}
