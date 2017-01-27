using System;
using System.Collections.Generic;

namespace CountRealNumbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            SortedDictionary<double, int> numsAndCounts = new SortedDictionary<double, int>();

            foreach (string numStr in input)
            {
                double number = double.Parse(numStr);

                if (numsAndCounts.ContainsKey(number))
                {
                    numsAndCounts[number]++;
                }
                else
                {
                    numsAndCounts[number] = 1;
                }
            }

            foreach (double num in numsAndCounts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, numsAndCounts[num]);
            }
        }
    }
}
