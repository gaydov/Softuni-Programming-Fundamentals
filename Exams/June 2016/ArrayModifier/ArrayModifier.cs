using System;
using System.Linq;

namespace ArrayModifier
{
    public class ArrayModifier
    {
        public static void Main()
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (!command[0].Equals("end"))
            {
                switch (command[0])
                {
                    case "swap":

                        int firstIndex = int.Parse(command[1]);
                        int secondIndex = int.Parse(command[2]);

                        long temp = array[firstIndex];
                        array[firstIndex] = array[secondIndex];
                        array[secondIndex] = temp;
                        break;

                    case "multiply":

                        firstIndex = int.Parse(command[1]);
                        secondIndex = int.Parse(command[2]);

                        long product = array[firstIndex] * array[secondIndex];
                        array[firstIndex] = product;
                        break;

                    case "decrease":

                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] -= 1;
                        }
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
