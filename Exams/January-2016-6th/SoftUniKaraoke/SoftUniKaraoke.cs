using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            string[] inputParticipants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string[] inputSongs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            string[] currentPerformance = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);

            Dictionary<string, List<string>> singersAndAwards = new Dictionary<string, List<string>>();

            while (!currentPerformance[0].Equals("dawn"))
            {
                string participant = currentPerformance[0];
                string song = currentPerformance[1];
                string award = currentPerformance[2];

                if (inputParticipants.Contains(participant) && inputSongs.Contains(song))
                {
                    if (!singersAndAwards.ContainsKey(participant))
                    {
                        singersAndAwards.Add(participant, new List<string>());
                        singersAndAwards[participant].Add(award);
                    }
                    else
                    {
                        if (!singersAndAwards[participant].Contains(award))
                        {
                            singersAndAwards[participant].Add(award);
                        }
                    }
                }

                currentPerformance = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None);
            }

            // If there are no stage performances:
            if (singersAndAwards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (KeyValuePair<string, List<string>> singer in singersAndAwards.OrderByDescending(p => p.Value.Count()).ThenBy(p => p.Key))
            {
                Console.WriteLine($"{singer.Key}: {singer.Value.Count} awards");

                string[] awardsCurrentSinger = singersAndAwards[singer.Key].OrderBy(a => a).ToArray();

                if (awardsCurrentSinger.Length > 0)
                {
                    foreach (string award in awardsCurrentSinger)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
                else
                {
                    Console.WriteLine("No awards");
                }
            }
        }
    }
}
