using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    public class MultiplyBigNumber
    {
        public static void Main()
        {
            string inputNum1 = Console.ReadLine().TrimStart('0');
            string inputNum2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            int lastDigit = 0;
            int remainder = 0;

            for (int i = inputNum1.Length - 1; i >= 0; i--)
            {
                int number1 = int.Parse(inputNum1[i].ToString());
                int number2 = int.Parse(inputNum2);

                if (number1 * number2 + remainder < 10)
                {
                    result.Append(number1 * number2 + remainder);
                    remainder = 0;
                }
                else
                {
                    lastDigit = (number1 * number2 + remainder) % 10;
                    result.Append(lastDigit);
                    remainder = (number1 * number2 + remainder) / 10;
                }
            }

            if (remainder != 0)
            {
                result.Append(remainder);
            }

            if (result.ToString().All(d => d.Equals('0')))
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(string.Join("", result.ToString().Reverse()));
            }
        }
    }
}
