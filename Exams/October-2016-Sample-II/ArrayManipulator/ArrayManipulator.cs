using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> inputList = new List<int>();
            inputList = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "exchange":

                        int index = int.Parse(command[1]);

                        if (index < 0 || index >= inputList.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            // There is no point to split after the last index so we break to the command input:
                            if (index == inputList.Count - 1)
                            {
                                break;
                            }

                            int[] exchange = inputList.Skip(index + 1).Take(inputList.Count).ToArray();
                            inputList.RemoveRange(index + 1, inputList.Count - index - 1);
                            inputList.InsertRange(0, exchange);
                        }
                        break;

                    case "max":

                        if (command[1].Equals("even"))
                        {
                            try
                            {
                                int maxElement = inputList.Where(e => e % 2 == 0).Max();
                                int maxElementIndex = inputList.LastIndexOf(maxElement);
                                Console.WriteLine(maxElementIndex);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        else if (command[1].Equals("odd"))
                        {
                            try
                            {
                                int maxElement = inputList.Where(e => e % 2 != 0).Max();
                                int maxElementIndex = inputList.LastIndexOf(maxElement);
                                Console.WriteLine(maxElementIndex);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "min":

                        if (command[1].Equals("even"))
                        {
                            try
                            {
                                int minElement = inputList.Where(e => e % 2 == 0).Min();
                                int minElementIndex = inputList.LastIndexOf(minElement);
                                Console.WriteLine(minElementIndex);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        else if (command[1].Equals("odd"))
                        {
                            try
                            {
                                int minElement = inputList.Where(e => e % 2 != 0).Min();
                                int minElementIndex = inputList.LastIndexOf(minElement);
                                Console.WriteLine(minElementIndex);
                            }
                            catch
                            {
                                Console.WriteLine("No matches");
                            }
                        }
                        break;

                    case "first":

                        int countElements = int.Parse(command[1]);

                        if (countElements > inputList.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (command[2].Equals("even"))
                            {
                                int[] evenElements = inputList.Where(e => e % 2 == 0).Take(countElements).ToArray();
                                Console.WriteLine($"[{string.Join(", ", evenElements)}]");
                            }
                            else if (command[2].Equals("odd"))
                            {
                                int[] oddElements = inputList.Where(e => e % 2 != 0).Take(countElements).ToArray();
                                Console.WriteLine($"[{string.Join(", ", oddElements)}]");
                            }
                        }
                        break;

                    case "last":

                        countElements = int.Parse(command[1]);

                        if (countElements > inputList.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            if (command[2].Equals("even"))
                            {
                                int[] evenElements = inputList.Where(e => e % 2 == 0).Reverse().Take(countElements).Reverse().ToArray();
                                Console.WriteLine($"[{string.Join(", ", evenElements)}]");
                            }
                            else if (command[2].Equals("odd"))
                            {
                                int[] oddElements = inputList.Where(e => e % 2 != 0).Reverse().Take(countElements).Reverse().ToArray();
                                Console.WriteLine($"[{string.Join(", ", oddElements)}]");
                            }
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"[{string.Join(", ", inputList)}]");
        }
    }
}
