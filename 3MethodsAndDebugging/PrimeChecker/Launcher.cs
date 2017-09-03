using System;

namespace PrimeChecker
{
    public class Launcher
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            IsPrime(number);
        }

        public static void IsPrime(long num)
        {
            bool isPrime = true;

            if (num == 0 || num == 1)
            {
                isPrime = false;
            }
            else
            {
                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                    }
                }
            }

            Console.WriteLine(isPrime);
        }
    }
}
