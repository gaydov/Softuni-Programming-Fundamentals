using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniWaterSupplies
{
    public class SoftUniWaterSupplies
    {
        public static void Main()
        {
            double totalWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int bottleCapacity = int.Parse(Console.ReadLine());
            double additionalWater = 0;
            List<int> indexes = new List<int>();
            bool isBottlesArrReversed = false;

            if (totalWater % 2 != 0)
            {
                Array.Reverse(bottles);
                isBottlesArrReversed = true;
            }

            for (int i = 0; i < bottles.Length; i++)
            {
                double waterToBeFilled = bottleCapacity - bottles[i];
                totalWater -= waterToBeFilled;

                if (totalWater < 0)
                {
                    SaveIndexOfEmptyBottle(bottles, indexes, isBottlesArrReversed, i);

                    for (int j = i + 1; j < bottles.Length; j++)
                    {
                        if (j == i + 1) // If we are at the first empty bottle we use the negative value of "totalWater" for a quantity to be added to "additionalWater"
                        {
                            additionalWater += Math.Abs(totalWater) + (bottleCapacity - bottles[j]);
                        }
                        else
                        {
                            additionalWater += bottleCapacity - bottles[j];
                        }

                        SaveIndexOfEmptyBottle(bottles, indexes, isBottlesArrReversed, j);
                    }

                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", indexes.Count);
                    Console.WriteLine("With indexes: {0}", string.Join(", ", indexes));
                    Console.WriteLine("We need {0} more liters!", additionalWater);
                    return;
                }
            }

            Console.WriteLine("Enough water!\nWater left: {0}l.", totalWater);
        }
        public static void SaveIndexOfEmptyBottle(double[] inputArray, List<int> indexes, bool isTheInputArrReversed, int currentIndex)
        {
            if (isTheInputArrReversed)
            {
                indexes.Add(inputArray.Length - currentIndex - 1);
            }
            else
            {
                indexes.Add(currentIndex);
            }
        }
    }
}
