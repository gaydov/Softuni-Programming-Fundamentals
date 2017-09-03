using System;

namespace DrawFilledSquare
{
    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            PrintFirstLastRow(n);
            PrintMiddleRows(n);
            PrintFirstLastRow(n);
        }

        public static void PrintFirstLastRow(int squareSide)
        {
            Console.WriteLine(new string('-', 2 * squareSide));
        }

        public static void PrintMiddleRows(int squareSide)
        {
            for (int row = 1; row <= squareSide - 2; row++)
            {
                Console.Write('-');

                for (int col = 1; col <= squareSide - 1; col++)
                {
                    Console.Write("\\/");
                }

                Console.WriteLine('-');
            }
        }
    }
}
