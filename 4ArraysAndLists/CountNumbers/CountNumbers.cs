using System;
using System.Collections.Generic;
using System.Linq;

namespace SortNumbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            nums.Sort();

            int count = 1;

            for (int i = 0; i <= nums.Count - 1; i++)
            {
                // If there is no next index we print the current number and its count:
                if ((i + 1) > nums.Count - 1)
                {
                    Console.WriteLine("{0} -> {1}", nums[i], count);
                }
                else if (nums[i] == nums[i + 1])
                {
                    count++;
                }
                else if (nums[i] != nums[i + 1])
                {
                    Console.WriteLine("{0} -> {1}", nums[i], count);
                    count = 1;
                }
            }
        }
    }
}
