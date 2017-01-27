using System;

namespace RoundingNumbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            string[] inputArray = Console.ReadLine().Split();

            double[] arrayNums = new double[inputArray.Length];

            for (int i = 0; i < arrayNums.Length; i++)
            {
                arrayNums[i] = double.Parse(inputArray[i]);
            }

            for (int i = 0; i < arrayNums.Length; i++)
            {
                double roundedNum = Math.Round(arrayNums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", arrayNums[i], roundedNum);
            }
        }
    }
}
