using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<decimal> numbers = new List<decimal>();

            foreach (string strNum in input)
            {
                numbers.Add(decimal.Parse(strNum));
            }

            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    Console.Write("{0}", numbers[i]);
                }
                else
                {
                    Console.Write("{0} <= ", numbers[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
