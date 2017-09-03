using System;
using System.Linq;

public class SequenceOfCommands
{
    public const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split(ArgumentsDelimiter)
            .Select(long.Parse)
            .ToArray();

        string command = Console.ReadLine();

        while (!command.Equals("stop"))
        {
            string[] line = command.Split(ArgumentsDelimiter);
            int[] args = new int[2];

            if (line[0].Equals("add") ||
                line[0].Equals("subtract") ||
                line[0].Equals("multiply"))
            {
                args[0] = int.Parse(line[1]);
                args[1] = int.Parse(line[2]);

                array = PerformAction(array, line[0], args);
            }

            array = PerformAction(array, command, args);

            PrintArray(array);
            Console.WriteLine();

            command = Console.ReadLine();
        }
    }

    private static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] innerArray = arr.Clone() as long[];
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                innerArray[pos - 1] *= value;
                break;
            case "add":
                innerArray[pos - 1] += value;
                break;
            case "subtract":
                innerArray[pos - 1] -= value;
                break;
            case "lshift":
                ArrayShiftLeft(innerArray);
                break;
            case "rshift":
                ArrayShiftRight(innerArray);
                break;
        }

        return innerArray;
    }

    private static void ArrayShiftRight(long[] array)
    {
        long leftDigit = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 1; i--)
        {
            array[i] = array[i - 1];
        }

        array[0] = leftDigit;
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long rigthDig = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[array.Length - 1] = rigthDig;
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
