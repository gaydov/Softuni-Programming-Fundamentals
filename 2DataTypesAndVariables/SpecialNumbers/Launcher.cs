using System;

namespace SpecialNumbers
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= count; currentNum++)
            {
                int number = currentNum; // creating separate variable in order not to break the loop
                int digit = 0;
                int sumDigits = 0;

                while (number > 0)
                {
                    digit = number % 10; // getting the last digit of the number
                    sumDigits += digit;
                    number /= 10; // removing the already used last digit
                }

                if (sumDigits == 5 || sumDigits == 7 || sumDigits == 11)
                {
                    Console.WriteLine("{0} -> True", currentNum);
                }
                else
                {
                    Console.WriteLine("{0} -> False", currentNum);
                }
            }
        }
    }
}
