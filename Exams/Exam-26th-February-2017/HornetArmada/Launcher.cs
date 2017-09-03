using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    // Creating class that will hold the details needed for each legion:
    public class LegionDetails
    {
        public long Activity { get; set; }

        public Dictionary<string, long> SoldiersTypeAndCount { get; set; }
    }

    public class Launcher
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, LegionDetails> legions = new Dictionary<string, LegionDetails>();

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(args[0]);
                string legionName = args[1];
                string soldierType = args[2];
                long soldiersCount = long.Parse(args[3]);

                // If the legion does not exist in the dictionary we add it:
                if (!legions.ContainsKey(legionName))
                {
                    LegionDetails currentLegion = new LegionDetails
                    {
                        Activity = lastActivity,
                        SoldiersTypeAndCount = new Dictionary<string, long> { [soldierType] = soldiersCount }
                    };
                    legions.Add(legionName, currentLegion);
                }
                else
                {
                    // If the legion exists in the dictionary but it does not have the current soldier type we add it:
                    if (!legions[legionName].SoldiersTypeAndCount.ContainsKey(soldierType))
                    {
                        legions[legionName].SoldiersTypeAndCount.Add(soldierType, soldiersCount);
                    }
                    else
                    {
                        // If there is already such type we just add the soldiers count to it
                        legions[legionName].SoldiersTypeAndCount[soldierType] += soldiersCount;
                    }

                    // If the current activity is lower than the previous one we change it:
                    if (lastActivity > legions[legionName].Activity)
                    {
                        legions[legionName].Activity = lastActivity;
                    }
                }
            }

            string[] queryArgs = Console.ReadLine().Split('\\');

            // When the query has 2 arguments then we have "search activity" and "search soldier type"
            if (queryArgs.Length > 1)
            {
                long searchActivity = long.Parse(queryArgs[0]);
                string searchSoldierType = queryArgs[1];

                foreach (KeyValuePair<string, LegionDetails> entry in legions.Where(x => x.Value.SoldiersTypeAndCount.ContainsKey(searchSoldierType) & x.Value.Activity < searchActivity).OrderByDescending(l => l.Value.SoldiersTypeAndCount[searchSoldierType]))
                {
                    Console.WriteLine($"{entry.Key} -> {entry.Value.SoldiersTypeAndCount[searchSoldierType]}");
                }
            }
            else
            {
                // If the argument is only one then we have only "search soldier type":
                string searchSoldierType = queryArgs[0];

                foreach (KeyValuePair<string, LegionDetails> entry in legions.Where(l => l.Value.SoldiersTypeAndCount.ContainsKey(searchSoldierType)).OrderByDescending(l => l.Value.Activity))
                {
                    Console.WriteLine($"{entry.Value.Activity} : {entry.Key}");
                }
            }
        }
    }
}
