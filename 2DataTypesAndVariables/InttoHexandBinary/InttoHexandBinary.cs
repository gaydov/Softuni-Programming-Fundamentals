using System;

namespace InttoHexandBinary
{
    public class InttoHexandBinary
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(number, 16).ToUpper());
            Console.WriteLine(Convert.ToString(number, 2).ToUpper());
        }
    }
}
