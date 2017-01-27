using System;
using System.Collections.Generic;
using System.Linq;

namespace PairsbyDifference
{
    public class PairsbyDifference
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int difference = int.Parse(Console.ReadLine());

            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];

                for (int j = 0; j < nums.Length; j++)
                {
                    if (currentNum - nums[j] == difference && currentNum - nums[j] > 0)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
