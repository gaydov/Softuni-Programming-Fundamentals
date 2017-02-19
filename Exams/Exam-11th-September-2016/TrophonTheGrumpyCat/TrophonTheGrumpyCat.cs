using System;
using System.Linq;

namespace TrophonTheGrumpyCat
{
    public class TrophonTheGrumpyCat
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItem = Console.ReadLine();
            string typePriceRatings = Console.ReadLine();

            long leftSum = 0;

            for (int i = 0; i < entryPoint; i++)
            {
                leftSum += GetCurrentItem(elements, entryPoint, typeOfItem, typePriceRatings, elements[i], i);
            }

            long rightSum = 0;

            for (int i = entryPoint + 1; i < elements.Length; i++)
            {
                rightSum += GetCurrentItem(elements, entryPoint, typeOfItem, typePriceRatings, elements[i], i);
            }

            if (leftSum >= rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        public static long GetCurrentItem(int[] elements, int entryPoint, string typeOfItem, string typePriceRatings, int currentElement, int index)
        {
            currentElement = 0;

            switch (typeOfItem)
            {
                case "cheap":

                    if (elements[index] < elements[entryPoint])
                    {
                        switch (typePriceRatings)
                        {
                            case "positive":

                                if (elements[index] > 0)
                                {
                                    currentElement = elements[index];
                                }
                                break;

                            case "negative":

                                if (elements[index] < 0)
                                {
                                    currentElement = elements[index];
                                }
                                break;

                            default:

                                currentElement = elements[index];
                                break;
                        }
                    }
                    break;

                case "expensive":

                    if (elements[index] >= elements[entryPoint])
                    {
                        switch (typePriceRatings)
                        {
                            case "positive":

                                if (elements[index] > 0)
                                {
                                    currentElement = elements[index];
                                }
                                break;

                            case "negative":

                                if (elements[index] < 0)
                                {
                                    currentElement = elements[index];
                                }
                                break;

                            default:
                                currentElement = elements[index];
                                break;
                        }
                    }
                    break;

                default:
                    break;
            }

            return currentElement;
        }
    }
}
