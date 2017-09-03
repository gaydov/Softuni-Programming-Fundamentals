using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    public class Launcher
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(number);
            int trailingZeors = CountTrailingZeros(factorial);
            Console.WriteLine(trailingZeors);
        }

        public static BigInteger GetFactorial(int n)
        {
            BigInteger factorial = 1;

            for (int currenNum = 1; currenNum <= n; currenNum++)
            {
                factorial = factorial * currenNum;
            }

            return factorial;
        }

        public static int CountTrailingZeros(BigInteger num)
        {
            int zerosCount = 0;
            BigInteger lastDigit = 0;

            while (lastDigit == 0)
            {
                lastDigit = num % 10;
                if (lastDigit == 0)
                {
                    zerosCount++;
                }

                num /= 10;
            }

            return zerosCount;
        }
    }
}
