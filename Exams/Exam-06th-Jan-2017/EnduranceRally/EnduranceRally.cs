using System;
using System.Linq;

namespace EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (string driver in drivers)
            {
                double fuel = driver[0];

                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }
                }

                if (fuel <= 0)
                {
                    continue;
                }

                Console.WriteLine($"{driver} - fuel left {fuel:F2}");
            }
        }
    }
}
