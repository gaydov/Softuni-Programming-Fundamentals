using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PopulationAggregation
{
    public class PopulationAggregation
    {
        public static void Main()
        {
            SortedDictionary<string, int> countriesAndCitiesCount = new SortedDictionary<string, int>();
            Dictionary<string, long> townsWithPopulation = new Dictionary<string, long>();

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] args = command.Split('\\');
                long population = long.Parse(args[2]);
                string country;
                string town;

                if (char.IsUpper(args[0][0]))
                {
                    country = args[0];
                    town = args[1];
                }
                else
                {
                    town = args[0];
                    country = args[1];
                }

                town = Regex.Replace(town, @"[@#$&0-9]", string.Empty);
                country = Regex.Replace(country, @"[@#$&0-9]", string.Empty);

                if (!countriesAndCitiesCount.ContainsKey(country))
                {
                    countriesAndCitiesCount.Add(country, 1);
                }
                else
                {
                    countriesAndCitiesCount[country] += 1;
                }

                if (!townsWithPopulation.ContainsKey(town))
                {
                    townsWithPopulation.Add(town, population);
                }
                else
                {
                    townsWithPopulation[town] = population;
                }

                command = Console.ReadLine();
            }

            // Printing the results:
            foreach (KeyValuePair<string, int> country in countriesAndCitiesCount)
            {
                Console.WriteLine($"{country.Key} -> {country.Value}");
            }

            foreach (KeyValuePair<string, long> town in townsWithPopulation.OrderByDescending(t => t.Value).Take(3))
            {
                Console.WriteLine($"{town.Key} -> {town.Value}");
            }
        }
    }
}
