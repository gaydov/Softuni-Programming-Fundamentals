using System;
using System.Collections.Generic;
using System.Linq;

namespace ListsMaxSequenceofEqualElements
{
    public class Launcher
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> nums = new List<int>();

            foreach (string inputNum in input)
            {
                nums.Add(int.Parse(inputNum));
            }

            int startPosition = 0;
            int bestStartPosition = 0;
            int length = 1;
            int biggestLength = 1;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    length++;

                    if (length == 2)
                    {
                        startPosition = i - 1;
                    }

                    if (length > biggestLength)
                    {
                        biggestLength = length;
                        bestStartPosition = startPosition;
                    }
                }
                else
                {
                    length = 1;
                }
            }

            for (int i = bestStartPosition; i < (bestStartPosition + biggestLength); i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
