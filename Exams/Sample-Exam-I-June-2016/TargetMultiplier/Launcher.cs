using System;
using System.Linq;

namespace TargetMultiplier
{
    public class Launcher
    {
        public static void Main()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimentions[0];
            int columns = dimentions[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] values = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            int[] targetCellArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int targetRow = targetCellArgs[0];
            int targetColumn = targetCellArgs[1];
            int targetCellOriginalValue = matrix[targetRow, targetColumn];

            // Calculating the sum of the neighboring cells:
            int sum = 0;

            for (int row = targetRow - 1; row <= targetRow + 1; row++)
            {
                for (int column = targetColumn - 1; column <= targetColumn + 1; column++)
                {
                    // Skipping the target cell:
                    if (row == targetRow && column == targetColumn)
                    {
                        continue;
                    }

                    sum += matrix[row, column];
                }
            }

            matrix[targetRow, targetColumn] = targetCellOriginalValue * sum;

            // Multiplying the neighboring cells with the target cell's original value:
            for (int row = targetRow - 1; row <= targetRow + 1; row++)
            {
                for (int column = targetColumn - 1; column <= targetColumn + 1; column++)
                {
                    // Skipping the target cell:
                    if (row == targetRow && column == targetColumn)
                    {
                        continue;
                    }

                    matrix[row, column] *= targetCellOriginalValue;
                }
            }

            // Printing the result matrix:
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write(matrix[row, column] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
