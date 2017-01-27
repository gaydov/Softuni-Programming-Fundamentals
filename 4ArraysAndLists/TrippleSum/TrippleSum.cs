using System;

namespace TrippleSum
{
    public class TrippleSum
    {
        public static void Main()
        {
            string[] arrayString = Console.ReadLine().Split();

            int[] arrayInt = new int[arrayString.Length];

            for (int inputIndex = 0; inputIndex < arrayInt.Length; inputIndex++)
            {
                arrayInt[inputIndex] = int.Parse(arrayString[inputIndex]);
            }

            bool isFound = false;
            for (int a = 0; a < arrayInt.Length - 1; a++)
            {
                for (int b = a + 1; b < arrayInt.Length; b++)
                {
                    for (int c = 0; c < arrayInt.Length; c++)
                    {
                        if (arrayInt[a] + arrayInt[b] == arrayInt[c])
                        {
                            Console.WriteLine("{0} + {1} == {2}", arrayInt[a], arrayInt[b], arrayInt[c]);
                            isFound = true;
                            break;
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
