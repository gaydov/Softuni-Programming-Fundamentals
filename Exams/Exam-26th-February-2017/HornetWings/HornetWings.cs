using System;

namespace HornetWings
{
    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceFor1000Flaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distanceTraveled = (wingFlaps / 1000.0) * distanceFor1000Flaps;
            int time = (wingFlaps / 100) + (wingFlaps / endurance) * 5;

            Console.WriteLine($"{distanceTraveled:F2} m.");
            Console.WriteLine($"{time} s.");
        }
    }
}
