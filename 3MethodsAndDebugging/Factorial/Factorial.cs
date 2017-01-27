using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger factorialN = GetFactorial(N);
            Console.WriteLine(factorialN);
        }

        public static BigInteger GetFactorial(int N)
        {
            BigInteger factorial = 1;

            for (int currenNum = 1; currenNum <= N; currenNum++)
            {
                factorial = factorial * currenNum;
            }

            return factorial;
        }
    }
}
