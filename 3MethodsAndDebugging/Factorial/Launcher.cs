using System;
using System.Numerics;

namespace Factorial
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = GetFactorial(n);

            Console.WriteLine(factorialN);
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
    }
}
