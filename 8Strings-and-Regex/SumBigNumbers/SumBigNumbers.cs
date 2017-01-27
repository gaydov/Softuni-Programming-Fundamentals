using System;
using System.Linq;
using System.Text;

namespace SumBigNumbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            string num1 = Console.ReadLine().TrimStart('0');
            string num2 = Console.ReadLine().TrimStart('0');
            StringBuilder result = new StringBuilder();

            if (num1.Length > num2.Length)
            {
                num2 = num2.PadLeft(num1.Length, '0');
            }
            else if (num2.Length > num1.Length)
            {
                num1 = num1.PadLeft(num2.Length, '0');
            }

            int lastDigit = 0;
            int remainder = 0;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                int number1 = int.Parse(num1[i].ToString());
                int number2 = int.Parse(num2[i].ToString());

                number1 += remainder;
                remainder = 0;

                if (number1 + number2 < 10)
                {
                    result.Append(number1 + number2);
                }
                else
                {
                    lastDigit = (number1 + number2) % 10;
                    result.Append(lastDigit);
                    remainder = (number1 + number2) / 10;
                }
            }

            if (remainder != 0)
            {
                result.Append(remainder);
            }

            Console.WriteLine(string.Join("", result.ToString().Reverse()));
        }
    }
}
