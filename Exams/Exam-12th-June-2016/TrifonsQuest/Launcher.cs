using System;
using System.Linq;

namespace TrifonsQuest
{
    public class Launcher
    {
        public static void Main()
        {
            long health = long.Parse(Console.ReadLine());
            int[] mapDimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = mapDimensions[0];
            int colums = mapDimensions[1];
            char[,] map = new char[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                char[] currentInput = Console.ReadLine().ToCharArray();

                for (int j = 0; j < colums; j++)
                {
                    map[i, j] = currentInput[j];
                }
            }

            int turns = 0;
            int col = 0;

            for (int row = 0; row < rows; row++)
            {
                // The quest is successful because the player went through all fields
                if (col == colums)
                {
                    PrintSuccessfulResult(health, turns);
                    return;
                }

                health = CalcHealth(map, row, col, turns, health);

                if (health <= 0)
                {
                    Console.WriteLine("Died at: [{0}, {1}]", row, col);
                    return;
                }

                turns = CalcTurns(map, row, col, turns);
                turns++;

                if (row == rows - 1)
                {
                    col++;
                    if (col >= colums)
                    {
                        PrintSuccessfulResult(health, turns);
                        return;
                    }

                    for (int opositeRow = rows - 1; opositeRow >= 0; opositeRow--)
                    {
                        health = CalcHealth(map, opositeRow, col, turns, health);

                        if (health <= 0)
                        {
                            Console.WriteLine("Died at: [{0}, {1}]", opositeRow, col);
                            return;
                        }

                        turns = CalcTurns(map, opositeRow, col, turns);
                        turns++;

                        if (opositeRow == 0)
                        {
                            col++;
                            row = -1;
                        }
                    }
                }
            }

            Console.WriteLine();
        }

        public static void PrintSuccessfulResult(long health, int turns)
        {
            Console.WriteLine("Quest completed!");
            Console.WriteLine($"Health: {health}");
            Console.WriteLine($"Turns: {turns}");
        }

        public static long CalcHealth(char[,] map, int row, int col, int turns, long inputHealth)
        {
            switch (map[row, col])
            {
                case 'F':
                    inputHealth -= turns / 2;
                    break;

                case 'H':
                    inputHealth += turns / 3;
                    break;

                default:
                    break;
            }

            return inputHealth;
        }

        public static int CalcTurns(char[,] map, int row, int col, int turns)
        {
            switch (map[row, col])
            {
                case 'T':
                    turns += 2;
                    break;
                default:
                    break;
            }

            return turns;
        }
    }
}
