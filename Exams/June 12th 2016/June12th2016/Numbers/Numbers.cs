using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers
{
    public class Numbers
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double avg = inputArr.Average();
            List<int> result = inputArr.Where(n => n > avg).OrderByDescending(n => n).Take(5).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
