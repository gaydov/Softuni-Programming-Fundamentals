using System;

namespace CondenseArraytoNumber
{
    public class CondenseArraytoNumber
    {
        public static void Main()
        {
            string[] arrStr = Console.ReadLine().Split();
            int[] arrNums = new int[arrStr.Length];

            for (int i = 0; i < arrNums.Length; i++)
            {
                arrNums[i] = int.Parse(arrStr[i]);
            }

            while(arrNums.Length > 1)
            {
                int[] condensed = new int[arrNums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    condensed[i] = arrNums[i] + arrNums[i + 1];
                }
                arrNums = condensed;
            }

            Console.WriteLine(string.Join(" ", arrNums));
        }
    }
}
