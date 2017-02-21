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
            int[] checkPoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (string driver in drivers)
            {
                double initialFuel = driver[0];

                for (int j = 0; j < zones.Length; j++)
                {
                    if (checkPoints.Contains(j))
                    {
                        initialFuel += zones[j];
                    }
                    else
                    {
                        initialFuel -= zones[j];
                    }

                    if (initialFuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {j}");
                        break;
                    }
                }

                if (initialFuel <= 0)
                {
                    continue;
                }

                Console.WriteLine($"{driver} - fuel left {initialFuel:F2}");
            }
        }
    }
}
