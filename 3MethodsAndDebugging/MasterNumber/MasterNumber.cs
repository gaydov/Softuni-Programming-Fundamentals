using System;

namespace MasterNumber
{
    public class MasterNumber
    {
        public static void Main()
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int currentNum = 1; currentNum <= endNumber; currentNum++)
            {
                if (IsNumPalindrome(currentNum) && SumOfDigits(currentNum) % 7 == 0 && HasTheNumEvenDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        public static bool IsNumPalindrome(int num)
        {
            int enteredNumber = num;
            int reversed = 0;
            int lastDigit = 0;

            while (num > 0)
            {
                lastDigit = num % 10;
                reversed = reversed * 10 + lastDigit;
                num /= 10;
            }

            bool isPalindrome = false;

            if (enteredNumber == reversed)
            {
                isPalindrome = true;
            }
            return isPalindrome;
        }

        public static int SumOfDigits(int num)
        {
            int sumDigits = 0;
            int lastDigit = 0;

            while (num > 0)
            {
                lastDigit = num % 10;
                sumDigits += lastDigit;
                num /= 10;
            }
            return sumDigits;
        }

        public static bool HasTheNumEvenDigit(int num)
        {
            bool hasEvenDigit = false;
            int lastDigit = 0;

            // 0 is considered to be even number so if the entered number is 0 the return is "true":
            if (num == 0)
            {
                hasEvenDigit = true;
            }

            while (num > 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    hasEvenDigit = true;
                    break;
                }
                num /= 10;
            }

            return hasEvenDigit;
        }
    }
}
