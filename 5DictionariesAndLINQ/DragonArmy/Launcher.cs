using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, Dragon>> dragons = new Dictionary<string, Dictionary<string, Dragon>>();
            int dragonsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < dragonsCount; i++)
            {
                string[] userInput = Console.ReadLine().Split();
                string type = userInput[0];
                string name = userInput[1];
                string inputDamage = userInput[2];
                string inputHealth = userInput[3];
                string inputArmor = userInput[4];

                Dragon currentDragon = new Dragon { Name = name };

                if (!inputDamage.Equals("null"))
                {
                    currentDragon.Damage = int.Parse(inputDamage);
                }

                if (!inputHealth.Equals("null"))
                {
                    currentDragon.Health = int.Parse(inputHealth);
                }

                if (!inputArmor.Equals("null"))
                {
                    currentDragon.Armor = int.Parse(inputArmor);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, Dragon>());
                    dragons[type].Add(name, currentDragon);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new Dragon());
                        dragons[type][name] = currentDragon;
                    }
                    else
                    {
                        dragons[type][name] = currentDragon;
                    }
                }
            }

            foreach (KeyValuePair<string, Dictionary<string, Dragon>> dragon in dragons)
            {
                double averageDamage = CalcAvgDragonProperty(dragons, dragon.Key, "Damage");
                double averageHealth = CalcAvgDragonProperty(dragons, dragon.Key, "Health");
                double averageArmor = CalcAvgDragonProperty(dragons, dragon.Key, "Armor");

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", dragon.Key, averageDamage, averageHealth, averageArmor);

                // All dragons of type "Red" for example:
                var dragonsOfThisType = dragons[dragon.Key].Values.Select(d => d).OrderBy(n => n.Name);

                foreach (Dragon dragonOfType in dragonsOfThisType)
                {
                    Console.WriteLine($"-{dragonOfType.Name} -> damage: {dragonOfType.Damage}, health: {dragonOfType.Health}, armor: {dragonOfType.Armor}");
                }
            }
        }

        public static double CalcAvgDragonProperty(Dictionary<string, Dictionary<string, Dragon>> dragonsCollection, string typeDragon, string property)
        {
            double avgProperty = 0;

            switch (property)
            {
                case "Damage":
                    avgProperty = dragonsCollection[typeDragon].Values.Average(d => d.Damage);
                    break;
                case "Health":
                    avgProperty = dragonsCollection[typeDragon].Values.Average(d => d.Health);
                    break;
                case "Armor":
                    avgProperty = dragonsCollection[typeDragon].Values.Average(d => d.Armor);
                    break;
            }

            return avgProperty;
        }
    }

    public class Dragon
    {
        public string Name { get; set; }

        public int Damage { get; set; } = 45; // Default value

        public int Health { get; set; } = 250;

        public int Armor { get; set; } = 10;
    }
}
