using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("shards", 0);
            materials.Add("motes", 0);
            materials.Add("fragments", 0);

            SortedDictionary<string, int> junk = new SortedDictionary<string, int>();

            while (true) 
            {
                List<string> input = Console.ReadLine().ToLower().Split().ToList();

                for (int i = 0; i < input.Count; i += 2)
                {
                    int value = int.Parse(input[i]);
                    string currentMaterial = input[i + 1];

                    if (currentMaterial.Equals("shards") || currentMaterial.Equals("fragments") || currentMaterial.Equals("motes"))
                    {
                        materials[currentMaterial] += value;

                        // If one of the materials is 250 or above in quantity we print the results and terminate the program:
                        if (materials[currentMaterial] >= 250)
                        {
                            materials[currentMaterial] -= 250; // From the total quantity of the winning material we subtract 250 because these points generate the item (Shadowmourne, Valanyr, Dragonwrath)
                            PrintLegendaryItem(currentMaterial, materials, junk);
                            return;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currentMaterial))
                        {
                            junk.Add(currentMaterial, value);
                        }
                        else
                        {
                            junk[currentMaterial] += value;
                        }
                    }
                }
            }
      
        }

        public static void PrintLegendaryItem(string winningMaterial, Dictionary<string, int> materials, SortedDictionary<string, int> junk)
        {
            switch (winningMaterial)
            {
                case "shards":
                    Console.WriteLine("Shadowmourne obtained!");
                    break;
                case "fragments":
                    Console.WriteLine("Valanyr obtained!");
                    break;
                case "motes":
                    Console.WriteLine("Dragonwrath obtained!");
                    break;
                default:
                    break;
            }

            foreach (KeyValuePair<string, int> material in materials.OrderByDescending(materialQuantity => materialQuantity.Value).ThenBy(materialName => materialName.Key))
            {
                Console.WriteLine("{0}: {1}", material.Key, material.Value);
            }

            foreach (KeyValuePair<string, int> junkMaterial in junk)
            {
                Console.WriteLine("{0}: {1}", junkMaterial.Key, junkMaterial.Value);
            }
        }
    }
}
