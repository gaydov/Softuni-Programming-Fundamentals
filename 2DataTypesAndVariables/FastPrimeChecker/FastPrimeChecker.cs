using System;

namespace FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int checkedNum = 2; checkedNum <= number; checkedNum++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(checkedNum); divisor++)
                {
                    if (checkedNum % divisor == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine($"{checkedNum} -> {isPrime}");
            }
        }
    }
}
