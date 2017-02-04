using System;

namespace CharityMarathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            int marathonLength = int.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            int avgLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            int maximumRunners = trackCapacity * marathonLength;

            if(runnersCount > maximumRunners)
            {
                runnersCount = maximumRunners;
            }

            long totalMeters = (long)runnersCount * avgLaps * lapLength;
            long totalKms = totalMeters / 1000;
            decimal moneyRaised = totalKms * moneyPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
