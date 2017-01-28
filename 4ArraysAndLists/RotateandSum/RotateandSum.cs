using System;

namespace RotateandSum
{
    public class RotateandSum
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());

            int[] numsArray = new int[inputArray.Length];

            // Parsing the string numbers to integers:
            for (int i = 0; i < inputArray.Length; i++)
            {
                numsArray[i] = int.Parse(inputArray[i]);
            }

            int[] sumArray = new int[numsArray.Length];

            for (int rotation = 0; rotation < rotations; rotation++)
            {
                int mostRightNum = numsArray[numsArray.Length - 1];

                for (int i = 0; i < numsArray.Length - 1; i++)
                {
                    numsArray[numsArray.Length - 1 - i] = numsArray[numsArray.Length - 2 - i];
                }
                numsArray[0] = mostRightNum;

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumArray[i] = sumArray[i] + numsArray[i];
                }
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
