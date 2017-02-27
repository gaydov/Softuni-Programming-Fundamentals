using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetAssault
{
    public class HornetAssault
    {
        public static void Main()
        {
            long[] beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                long power = hornets.Sum();

                if (power > beehives[i]) // If the hornets' power is bigger - the beehive disappears:
                {
                    beehives[i] = 0;
                }
                else // Else - current hornet disappears:
                {
                    beehives[i] -= power;
                    hornets.RemoveAt(0);
                }

                // If all hornets are dead we exit the loop:
                if (hornets.Count == 0)
                {
                    break;
                }
            }

            if (beehives.Any(e => e > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(e => e > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
