using System;

namespace CompareCharArrays
{
    public class Launcher
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            char[] arr1 = new char[firstArray.Length];
            char[] arr2 = new char[secondArray.Length];

            for (int i = 0; i < firstArray.Length; i++)
            {
                arr1[i] = char.Parse(firstArray[i]);
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                arr2[i] = char.Parse(secondArray[i]);
            }

            int shorterArr = Math.Min(arr1.Length, arr2.Length);

            bool isCharEqual = false;

            for (int i = 0; i < shorterArr; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(string.Join(string.Empty, arr1));
                    Console.WriteLine(string.Join(string.Empty, arr2));
                    return;
                }
                else if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(string.Join(string.Empty, arr2));
                    Console.WriteLine(string.Join(string.Empty, arr1));
                    return;
                }
                else
                {
                    isCharEqual = true;
                    continue;
                }
            }

            // If the boolean variable remains true both strings are equal:
            if (isCharEqual)
            {
                if (arr1.Length < arr2.Length)
                {
                    Console.WriteLine(string.Join(string.Empty, arr1));
                    Console.WriteLine(string.Join(string.Empty, arr2));
                }
                else
                {
                    Console.WriteLine(string.Join(string.Empty, arr2));
                    Console.WriteLine(string.Join(string.Empty, arr1));
                }
            }
        }
    }
}
