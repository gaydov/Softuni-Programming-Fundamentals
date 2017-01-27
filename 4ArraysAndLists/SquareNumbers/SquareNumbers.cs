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
            List<int> output = new List<int>();

            foreach (string strNum in input)
            {
                int num = int.Parse(strNum);

                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    output.Add(num);
                }
            }

            output.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
