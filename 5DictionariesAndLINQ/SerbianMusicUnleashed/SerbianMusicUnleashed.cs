using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SerbianMusicUnleashed
{
    public class SerbianMusicUnleashed
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> venuesAndSingers = new Dictionary<string, Dictionary<string, long>>();
            string pattern = @"([A-Za-z]+ ?[A-Za-z]+ ?[A-Za-z]+) @([A-Za-z]+ ?[A-Za-z]+ ?[A-Za-z]+) (\d+) (\d+)";
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                bool isCorrectInput = Regex.IsMatch(input, pattern);
                if (!isCorrectInput)
                {
                    input = Console.ReadLine();
                    continue;
                }

                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);

                string singer = match.Groups[1].ToString();
                string venue = match.Groups[2].ToString();
                int ticketPrice = int.Parse(match.Groups[3].ToString());
                int ticketsCount = int.Parse(match.Groups[4].ToString());
                long moneyMade = ticketPrice * ticketsCount; 

                if (!venuesAndSingers.ContainsKey(venue))
                {
                    venuesAndSingers.Add(venue, new Dictionary<string, long>());
                    venuesAndSingers[venue].Add(singer, moneyMade);
                }
                else
                {
                    if(!venuesAndSingers[venue].ContainsKey(singer))
                    {
                        venuesAndSingers[venue].Add(singer, moneyMade);
                    }
                    else
                    {
                        venuesAndSingers[venue][singer] += moneyMade;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, long>> venue in venuesAndSingers)
            {
                Console.WriteLine(venue.Key);

                foreach (KeyValuePair<string, long> singer in venue.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
