using System;

namespace ConvertSpeedUnits
{
    public class Launcher
    {
        public static void Main()
        {
            int distanceMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            int timeSeconds = (hours * 3600) + (minutes * 60) + seconds;
            float speedMetersSec = (float)distanceMeters / timeSeconds;
            float speedKmHour = ((float)distanceMeters / 1000) / ((float)timeSeconds / 3600);
            float speedMiHour = ((float)distanceMeters / 1609) / ((float)timeSeconds / 3600);

            Console.WriteLine("{0}\n{1}\n{2}", speedMetersSec, speedKmHour, speedMiHour);
        }
    }
}
