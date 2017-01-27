using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                index = i;

                for (int numLeft = 0; numLeft <= i - 1; numLeft++)
                {
                    leftSum += nums[numLeft];
                }

                for (int numRight = i + 1; numRight < nums.Length; numRight++)
                {
                    rightSum += nums[numRight];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
