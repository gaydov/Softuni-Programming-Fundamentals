using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            List<string> participants = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Regex.Split(Console.ReadLine(), @",\s*").ToList();
            Dictionary<string, List<string>> winnersAndAwards = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (!input.Equals("dawn"))
            {
                string[] performance = Regex.Split(input, @",\s*");
                string singer = performance[0];
                string song = performance[1];
                string award = performance[2];

                if (participants.Contains(singer) && songs.Contains(song))
                {
                    if (!winnersAndAwards.ContainsKey(singer))
                    {
                        winnersAndAwards.Add(singer, new List<string>());
                        winnersAndAwards[singer].Add(award);
                    }
                    else
                    {
                        winnersAndAwards[singer].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            if (winnersAndAwards.Count != 0)
            {
                foreach (KeyValuePair<string, List<string>> winner in winnersAndAwards.OrderByDescending(w => w.Value.Distinct().Count()).ThenBy(w => w.Key))
                {
                    Console.WriteLine($"{winner.Key}: {winner.Value.Distinct().Count()} awards");

                    foreach (string award in winner.Value.Distinct().OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
