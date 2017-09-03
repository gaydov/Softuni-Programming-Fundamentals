using System;
using System.Collections.Generic;

namespace PrimesinGivenRange
{
    public class Launcher
    {
        public static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = PrimesInRange(startNumber, endNumber);

            Console.WriteLine(string.Join(", ", primeNumbers));
        }

        public static List<int> PrimesInRange(int startNum, int endNum)
        {
            List<int> primesList = new List<int>(); // creating List of integers that will contain the prime integers found

            // creating for loop checking every integer in the range:
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                bool isPrime = true; // the number is considered prime by default

                if (currentNum == 0 || currentNum == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int divisor = 2; divisor <= Math.Sqrt(currentNum); divisor++)
                    {
                        if (currentNum % divisor == 0)
                        {
                            isPrime = false; // if the number can be divided by any number between 2 and Sqrt(number) without a remainder it is not a prime one
                        }
                    }
                }

                if (isPrime)
                {
                    primesList.Add(currentNum); // if the number is prime we add it to the list
                }
            }

            return primesList;
        }
    }
}
