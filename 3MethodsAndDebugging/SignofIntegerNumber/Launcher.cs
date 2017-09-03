using System;

namespace SignofIntegerNumber
{
    public class Launcher
    {
        public static void Main()
        {
            int inputNum = int.Parse(Console.ReadLine());
            PrintSignOfaNumber(inputNum);
        }

        public static void PrintSignOfaNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
