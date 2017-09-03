using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    public class Launcher
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<int> nums = new List<int>();

            foreach (string strNum in input)
            {
                nums.Add(int.Parse(strNum));
            }

            string[] command = Console.ReadLine().Split();

            do
            {
                switch (command[0])
                {
                    case "add":
                        AddElementAtIndex(command[1], command[2], nums);
                        break;
                    case "addMany":
                        AddManyElementsAtIndex(command[1], command, nums);
                        break;
                    case "contains":
                        ContainsElement(command[1], nums);
                        break;
                    case "remove":
                        int index = int.Parse(command[1]);
                        nums.RemoveAt(index);
                        break;
                    case "shift":
                        ShiftArrayPositions(command[1], nums);
                        break;
                    case "sumPairs":
                        nums = SumArrayPairs(nums);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split();
            }
            while (command[0] != "print");

            Console.WriteLine("[{0}]", string.Join(", ", nums));
        }

        public static List<int> SumArrayPairs(List<int> numbers)
        {
            // Creating new list that will hold the summed values of each pair:
            List<int> sumed = new List<int>();

            for (int i = 1; i <= numbers.Count; i = i + 2)
            {
                int pairSum = 0;
                if (i != numbers.Count)
                {
                    pairSum = numbers[i] + numbers[i - 1];
                }
                else
                {
                    // If the list has an odd count the last digit in it will be the last pair:
                    pairSum = numbers[numbers.Count - 1];
                }

                sumed.Add(pairSum);
            }

            numbers = sumed;
            return numbers;
        }

        public static void ShiftArrayPositions(string positions, List<int> numbers)
        {
            int shiftPositions = int.Parse(positions);

            for (int i = 0; i < shiftPositions; i++)
            {
                // Storing the first digit of the array:
                int firstDigit = numbers[0];

                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    numbers[j] = numbers[j + 1];
                }

                // After the repositioning of the digits for the current rotation we replace the last digit in the shifted array 
                // with the already stored one that was first digit:
                numbers[numbers.Count - 1] = firstDigit;
            }
        }

        public static void ContainsElement(string element, List<int> numbers)
        {
            int checkedElement = int.Parse(element);

            // Checking the original list for that element and prints its index if it exists in the list:
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == checkedElement)
                {
                    Console.WriteLine(i);
                    return; // If there is such an element we exit the method after printing it
                }
            }

            // If there is no such element we print "-1":
            Console.WriteLine(-1);
        }

        public static void AddManyElementsAtIndex(string index, string[] command, List<int> numbers)
        {
            // Creating a list where we will store the elements that will be added to our original list:
            List<int> addElements = new List<int>();

            // Filling that list with the elements that we want to add:
            for (int i = 2; i < command.Length; i++)
            {
                addElements.Add(int.Parse(command[i]));
            }

            int atIndex = int.Parse(index);

            // Adding the desired elements to the original list:
            numbers.InsertRange(atIndex, addElements);
        }

        public static void AddElementAtIndex(string index, string element, List<int> numbers)
        {
            int atIndex = int.Parse(index);
            int addedElement = int.Parse(element);

            numbers.Insert(atIndex, addedElement);
        }
    }
}
