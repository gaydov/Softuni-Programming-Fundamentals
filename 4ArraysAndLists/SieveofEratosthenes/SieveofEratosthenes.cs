using System;

namespace SieveofEratosthenes
{
    public class SieveofEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = i + 1;
            }

            int[] primes = new int[input.Length];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == 0)  // If the number is already marked as composite we skip the check for it
                {
                    continue;
                }

                int incrementator = input[i];

                for (int currentNumIndex = i; currentNumIndex < input.Length; currentNumIndex = currentNumIndex + incrementator)
                {
                    if (currentNumIndex == i)  // If we check the number for the first time we add it to the primes array
                    {
                        primes[currentNumIndex] = input[currentNumIndex];
                    }
                    else  // If the number is already checked we change its value to 0
                    {
                        input[currentNumIndex] = 0;
                    }
                }
            }

            for (int i = 0; i < primes.Length; i++)
            {
                if (primes[i] != 0)
                {
                    Console.Write("{0} ", primes[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
