using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumber
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int[] nums = new int[input.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }
           
            int biggestOccurence = 0;
            int mostFrequentNum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                int occurrences = 1;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (currentNum == nums[j])
                    {
                        occurrences++;
                    }
                }

                if(occurrences > biggestOccurence)
                {
                    biggestOccurence = occurrences;
                    mostFrequentNum = currentNum;
                }
            }

            Console.WriteLine(mostFrequentNum);
        }
    }
}
