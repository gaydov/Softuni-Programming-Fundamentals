using System;
using System.Linq;

namespace Largest3Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] result = numbers.OrderByDescending(num => num).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
