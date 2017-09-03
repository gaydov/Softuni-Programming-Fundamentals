using System;

namespace LargestCommonEnd
{
    public class Launcher
    {
        public static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            int shorterArray = Math.Min(firstInput.Length, secondInput.Length);
            int leftCounter = 0;
            int rightCounter = 0;

            // Scanning from left to right:
            for (int leftIndex = 0; leftIndex < shorterArray; leftIndex++)
            {
                if (firstInput[leftIndex] == secondInput[leftIndex])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }

            // Scanning from right to left:
            for (int rightIndex = 0; rightIndex < shorterArray; rightIndex++)
            {
                if (firstInput[firstInput.Length - 1 - rightIndex] == secondInput[secondInput.Length - 1 - rightIndex])
                {
                    rightCounter++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(Math.Max(leftCounter, rightCounter));
        }
    }
}
