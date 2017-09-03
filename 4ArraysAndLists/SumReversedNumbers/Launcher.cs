using System;
using System.Collections.Generic;
using System.Linq;

namespace SumReversedNumbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> reversedNums = new List<int>();

            for (int i = 0; i < input.Count; i++)
            {
                string strNum = input[i];
                char[] element = strNum.ToCharArray();
                char[] reversed = element.Reverse().ToArray();
                reversedNums.Add(int.Parse(string.Join(string.Empty, reversed)));
            }

            int sum = 0;

            for (int i = 0; i < reversedNums.Count; i++)
            {
                sum += reversedNums[i];
            }

            Console.WriteLine(sum);
        }
    }
}
