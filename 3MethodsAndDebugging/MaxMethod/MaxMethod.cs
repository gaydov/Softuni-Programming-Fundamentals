using System;

namespace MaxMethod
{
    public class MaxMethod
    {
        public static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int biggestNum = GetMaxInt(num1, num2, num3);
            Console.WriteLine(biggestNum);
        }
        private static int GetMaxInt(int number1, int number2, int number3)
        {
            int biggestNumber = Math.Max(Math.Max(number1, number2), number3);
            return biggestNumber;
        }
    }
}
