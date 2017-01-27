using System;

namespace MultiplyEvensbyOdds
{
    public class MultiplyEvensbyOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumOdds = GetSumOfOddDigits(number);
            int sumEvens = GetSumOfEvenDigits(number);
            Console.WriteLine(sumOdds * sumEvens);
        }

        public static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sumEvens = 0;
            for (int i = 0; number > 0; i++)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    sumEvens += digit;
                }
                number = number / 10;
            }

            return sumEvens;
        }

        public static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sumOdds = 0;
            for (int i = 0; number > 0; i++)
            {
                int digit = number % 10; 
                if (digit % 2 != 0)
                {
                    sumOdds += digit;
                }
                number = number / 10; 
            }

            return sumOdds;
        }
    }
}
