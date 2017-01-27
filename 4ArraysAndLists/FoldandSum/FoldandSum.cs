using System;
using System.Collections.Generic;
using System.Linq;

namespace FoldandSum
{
    public class FoldandSum
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int k = nums.Length / 4;

            // Creating 2 arrays that will hold the left and right k elements
            int[] left = new int[k];
            int[] rigth = new int[k];

            // Populating both arrays:
            for (int i = 0; i < left.Length; i++)
            {
                left[i] = nums[i];
            }

            for (int i = 0; i < rigth.Length; i++)
            {
                rigth[i] = nums[nums.Length - k + i];
            }

            // Reversing both arrays:
            Array.Reverse(left);
            Array.Reverse(rigth);

            // Creating an array that will contain the left and right parts combined:
            int[] foldedRow = new int[2 * left.Length];

            for (int i = 0; i < foldedRow.Length; i++)
            {
                if (i <= foldedRow.Length / 2 - 1)
                {
                    foldedRow[i] = left[i];
                }
                else
                {
                    foldedRow[i] = rigth[i - rigth.Length];
                }
            }

            // Creating and populating array that will hold the result of the sum:
            int[] result = new int[foldedRow.Length];

            for (int i = 0; i < foldedRow.Length; i++)
            {
                result[i] = foldedRow[i] + nums[k + i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
