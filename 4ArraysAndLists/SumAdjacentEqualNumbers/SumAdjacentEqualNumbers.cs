using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacentEqualNumbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<double> nums = new List<double>();

            foreach (string inputNum in input)
            {
                nums.Add(double.Parse(inputNum));
            }

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    nums[i] = nums[i] + nums[i + 1];
                    nums.Remove(nums[i + 1]);
                    i = -1; // In order the loop to start from the beginning after the modification of the list
                }
            }

            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
