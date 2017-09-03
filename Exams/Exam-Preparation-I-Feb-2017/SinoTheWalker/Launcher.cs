using System;

namespace SinoTheWalker
{
    public class Launcher
    {
        public static void Main()
        {
            DateTime leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
            int stepsCount = int.Parse(Console.ReadLine());
            int timePerStep = int.Parse(Console.ReadLine());

            long walkingTime = (stepsCount % 86400) * (timePerStep % 86400);
            DateTime arrivalTime = leavingTime.AddSeconds(walkingTime);

            Console.WriteLine($"Time Arrival: {arrivalTime.Hour:D2}:{arrivalTime.Minute:D2}:{arrivalTime.Second:D2}");
        }
    }
}
