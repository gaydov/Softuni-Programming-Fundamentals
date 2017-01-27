using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] parameters = Console.ReadLine().Split();
            int target = int.Parse(parameters[0]);
            int radius = int.Parse(parameters[1]);

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == target)
                {
                    int startIndex = Math.Max(0, i - radius);
                    int blast = Math.Min((2 * radius) + 1, nums.Count - startIndex);
                    nums.RemoveRange(startIndex, blast);
                    i = -1; // We put "i" to be -1 in order to check all the elements again
                }
            }

            long sum = 0;
            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
