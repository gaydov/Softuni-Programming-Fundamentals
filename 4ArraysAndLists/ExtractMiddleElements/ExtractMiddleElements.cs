using System;

namespace ExtractMiddleElements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            string[] arrStr = Console.ReadLine().Split();
            int[] arrInts = new int[arrStr.Length];

            for (int i = 0; i < arrInts.Length; i++)
            {
                arrInts[i] = int.Parse(arrStr[i]);
            }

            ExctractMiddleElementsArr(arrInts);
        }

        public static void ExctractMiddleElementsArr(int[] arrNumbers)
        {
            if (arrNumbers.Length == 1)
            {
                Console.WriteLine("{{ {0} }}", arrNumbers[0]);
            }
            else if (arrNumbers.Length % 2 == 0)
            {
                int firstElement = (arrNumbers.Length / 2) - 1;
                int secondElement = (arrNumbers.Length / 2);

                Console.WriteLine("{{ {0}, {1} }}", arrNumbers[firstElement], arrNumbers[secondElement]);
            }
            else
            {
                int firstElement = (arrNumbers.Length / 2) - 1;
                int secondElement = (arrNumbers.Length / 2);
                int thirdElement = (arrNumbers.Length / 2) + 1;

                Console.WriteLine("{{ {0}, {1}, {2} }}", arrNumbers[firstElement], arrNumbers[secondElement], arrNumbers[thirdElement]);
            }
        }
    }
}
