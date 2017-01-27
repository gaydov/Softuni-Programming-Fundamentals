using System;

namespace MathPower
{
    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double numberOnPower = NumPowered(number, power);
            Console.WriteLine(numberOnPower);
        }
        public static double NumPowered(double number, int power)
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }
    }
}
