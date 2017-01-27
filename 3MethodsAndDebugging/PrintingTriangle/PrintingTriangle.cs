using System;

namespace PrintingTriangle
{
    public class PrintingTriangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTringle(n);
        }
        public static void PrintTringle(int number)
        {
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }

            for (int row = number - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{col} ");
                }
                Console.WriteLine();
            }
        }
    }
}
