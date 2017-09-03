using System;

namespace EnglishNameofLastDigit
{
    public class Launcher
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string lastDigitName = GetLastDigitName(number);

            Console.WriteLine(lastDigitName);
        }

        public static string GetLastDigitName(long num)
        {
            num = Math.Abs(num) % 10;
            string lastDigit = string.Empty;

            switch (num)
            {
                case 0:
                    lastDigit = "zero";
                    break;
                case 1:
                    lastDigit = "one";
                    break;
                case 2:
                    lastDigit = "two";
                    break;
                case 3:
                    lastDigit = "three";
                    break;
                case 4:
                    lastDigit = "four";
                    break;
                case 5:
                    lastDigit = "five";
                    break;
                case 6:
                    lastDigit = "six";
                    break;
                case 7:
                    lastDigit = "seven";
                    break;
                case 8:
                    lastDigit = "eight";
                    break;
                case 9:
                    lastDigit = "nine";
                    break;
                default:
                    break;
            }

            return lastDigit;
        }
    }
}
