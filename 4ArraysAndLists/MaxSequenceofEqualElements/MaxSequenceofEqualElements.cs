using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    public class MaxSequenceofEqualElements
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int startPos = 0;
            int bestStartPos = 0;
            int length = 1;
            int biggestLength = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    length++;

                    if (length == 2)
                    {
                        startPos = i - 1;
                    }

                    if (length > biggestLength)
                    {
                        biggestLength = length;
                        bestStartPos = startPos;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            for (int i = bestStartPos; i < (bestStartPos + biggestLength); i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
