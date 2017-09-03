using System;
using System.Collections.Generic;
using System.Linq;

namespace MatrixOperator
{
    public class Launcher
    {
        public static void Main()
        {
            List<List<int>> table = new List<List<int>>();
            int rowsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < rowsCount; i++)
            {
                List<int> currentRow = new List<int>();
                currentRow = Console.ReadLine().Split().Select(int.Parse).ToList();
                table.Add(currentRow);
            }

            string[] cmdArgs = Console.ReadLine().Split();

            while (!cmdArgs[0].Equals("end"))
            {
                switch (cmdArgs[0])
                {
                    case "remove":

                        string typeOfNumber = cmdArgs[1];
                        string rowOrColumn = cmdArgs[2];
                        int positionOfElement = int.Parse(cmdArgs[3]);

                        RemoveElements(table, typeOfNumber, rowOrColumn, positionOfElement);
                        break;

                    case "swap":

                        int firstRow = int.Parse(cmdArgs[1]);
                        int secondRow = int.Parse(cmdArgs[2]);

                        List<int> temp = table[firstRow];
                        table[firstRow] = table[secondRow];
                        table[secondRow] = temp;
                        break;

                    case "insert":

                        int row = int.Parse(cmdArgs[1]);
                        int element = int.Parse(cmdArgs[2]);
                        table[row].Insert(0, element);
                        break;
                }

                cmdArgs = Console.ReadLine().Split();
            }

            foreach (List<int> row in table)
            {
                foreach (int element in row)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }
        }

        public static void RemoveElements(List<List<int>> table, string type, string rowOrCol, int position)
        {
            switch (type)
            {
                case "positive":

                    if (rowOrCol.Equals("row"))
                    {
                        table[position].RemoveAll(d => d >= 0);
                    }
                    else if (rowOrCol.Equals("col"))
                    {
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (table[i].Count > position && table[i][position] >= 0)
                            {
                                table[i].RemoveAt(position);
                            }
                        }
                    }

                    break;

                case "negative":

                    if (rowOrCol.Equals("row"))
                    {
                        table[position].RemoveAll(d => d < 0);
                    }
                    else if (rowOrCol.Equals("col"))
                    {
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (table[i].Count > position && table[i][position] < 0)
                            {
                                table[i].RemoveAt(position);
                            }
                        }
                    }

                    break;

                case "odd":

                    if (rowOrCol.Equals("row"))
                    {
                        table[position].RemoveAll(d => d % 2 != 0);
                    }
                    else if (rowOrCol.Equals("col"))
                    {
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (table[i].Count > position && table[i][position] % 2 != 0)
                            {
                                table[i].RemoveAt(position);
                            }
                        }
                    }

                    break;

                case "even":

                    if (rowOrCol.Equals("row"))
                    {
                        table[position].RemoveAll(d => d % 2 == 0);
                    }
                    else if (rowOrCol.Equals("col"))
                    {
                        for (int i = 0; i < table.Count; i++)
                        {
                            if (table[i].Count > position && table[i][position] % 2 == 0)
                            {
                                table[i].RemoveAt(position);
                            }
                        }
                    }

                    break;
            }
        }
    }
}
