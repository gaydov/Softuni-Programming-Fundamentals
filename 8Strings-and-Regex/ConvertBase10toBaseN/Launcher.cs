using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace ConvertBase10toBaseN
{
    public class Launcher
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int baseValue = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            int remainder = 0;

            StringBuilder binary = new StringBuilder();

            while (number > 0)
            {
                remainder = (int)(number % baseValue);
                binary.Append(remainder);
                number = number / baseValue;
            }

            Console.WriteLine(string.Join(string.Empty, binary.ToString().ToCharArray().Reverse()));
        }
    }
}
