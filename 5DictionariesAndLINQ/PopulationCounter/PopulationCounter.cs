using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            while (!input[0].Equals("report"))
            {
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    countries[country].Add(city, population);
                }
                else
                {
                    countries[country].Add(city, population);
                }

                input = Console.ReadLine().Split('|');
            }

            GetPopulationCountByCountry(countries);
        }

        public static void GetPopulationCountByCountry(Dictionary<string, Dictionary<string, long>> countries)
        {
            // Creating dictionary where we will store each country and its total population:
            Dictionary<string, long> totalCountryPopulation = new Dictionary<string, long>();

            foreach (KeyValuePair<string, Dictionary<string, long>> country in countries)
            {
                long populationCountry = countries[country.Key].Values.Sum();
                totalCountryPopulation.Add(country.Key, populationCountry);
            }

            // Ordering the total populations by their values:
            foreach (KeyValuePair<string, long> entry in totalCountryPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} (total population: {1})", entry.Key, entry.Value);

                // Printing all cities of the countries in descending order by their values:
                foreach (KeyValuePair<string, long> city in countries[entry.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
                }
            }
        }
    }
}
