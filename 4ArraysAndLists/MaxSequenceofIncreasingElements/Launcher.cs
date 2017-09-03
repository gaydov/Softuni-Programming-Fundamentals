using System;

namespace MaxSequenceofIncreasingElements
{
    public class Launcher
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
            int bestPos = 0;
            int length = 1;
            int bestLen = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    length++;

                    if (length == 2)
                    {
                        startPos = i - 1;
                    }

                    if (length > bestLen)
                    {
                        bestLen = length;
                        bestPos = startPos;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            for (int i = bestPos; i < (bestPos + bestLen); i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
