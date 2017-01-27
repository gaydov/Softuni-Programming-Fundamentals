using System;
using System.Numerics;

namespace ConvertBaseNtoBase10
{
    public class ConvertBaseNtoBase10
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            BigInteger baseValue = BigInteger.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            int power = 0;
            BigInteger currentNum = 0;

            while (number > 0)
            {
                int mostRightDigit = (int)(number % 10);
                currentNum = mostRightDigit * (BigInteger.Pow(baseValue, power));
                number = number / 10;
                power++;
                result += currentNum;
            }

            Console.WriteLine(result);
        }
    }
}
