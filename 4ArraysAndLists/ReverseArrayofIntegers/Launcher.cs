using System;

namespace ReverseArrayofIntegers
{
    public class Launcher
    {
        public static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());

            int[] intArray = new int[arraySize];

            for (int inputIndex = 0; inputIndex < intArray.Length; inputIndex++)
            {
                intArray[inputIndex] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int arrIndex = 0; arrIndex < intArray.Length / 2; arrIndex++)
            {
                int currentNum = intArray[arrIndex];
                intArray[arrIndex] = intArray[intArray.Length - arrIndex - 1];
                intArray[intArray.Length - arrIndex - 1] = currentNum;
            }

            Console.WriteLine(string.Join(" ", intArray));
        }
    }
}
