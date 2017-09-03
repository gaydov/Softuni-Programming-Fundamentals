using System;

namespace SumArrays
{
    public class Launcher
    {
        public static void Main()
        {
            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            // creating and populating 2 int arrays:
            int[] arr1Nums = new int[arr1.Length];
            int[] arr2Nums = new int[arr2.Length];

            for (int i = 0; i < arr1Nums.Length; i++)
            {
                arr1Nums[i] = int.Parse(arr1[i]);
            }

            for (int i = 0; i < arr2Nums.Length; i++)
            {
                arr2Nums[i] = int.Parse(arr2[i]);
            }

            // getting the length of the bigger array:
            int biggerArrLength = Math.Max(arr1Nums.Length, arr2Nums.Length);

            // creating an array that will hold the sum with length equal to the bigger length
            int[] sumArr = new int[biggerArrLength];

            for (int i = 0; i < sumArr.Length; i++)
            {
                sumArr[i] = arr1Nums[i % arr1Nums.Length] + arr2Nums[i % arr2Nums.Length];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
