using System;
using System.Linq;

namespace FoldandSum
{
    public class Launcher
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] row1Left = input.Take(k).Reverse().ToArray();
            int[] row1Right = input.Skip(3 * k).Reverse().ToArray();
            int[] row1 = row1Left.Concat(row1Right).ToArray();

            int[] row2 = input.Skip(k).Take(2 * k).ToArray();

            int[] result = row1.Select((num, i) => num + row2[i]).ToArray();

            // for (int i = 0; i < result.Length; i++)
            // {
            //     result[i] = row1[i] + row2[i];
            // }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
