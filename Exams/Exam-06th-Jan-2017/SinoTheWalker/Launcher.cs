using System;

namespace SinoTheWalker
{
    public class Launcher
    {
        public static void Main()
        {
            DateTime leavingTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", null);
            int steps = int.Parse(Console.ReadLine()) % 86400;
            int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;
            double walkingTime = (double)steps * secondsPerStep;
            
            DateTime arrivalTime = leavingTime.AddSeconds(walkingTime);
          
            Console.WriteLine($"Time Arrival: {arrivalTime.Hour:D2}:{arrivalTime.Minute:D2}:{arrivalTime.Second:D2}");
        }
    }
}
