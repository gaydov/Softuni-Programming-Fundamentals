using System;
using System.Collections.Generic;
using System.Linq;

namespace HornetArmada
{
    // Creating class that will hold the details needed for each legion:
    public class LegionDetails
    {
        public long Activity { get; set; }
        public Dictionary<string, long> soldiersTypeAndCout { get; set; }
    }
    public class HornetArmada
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            Dictionary<string, LegionDetails> legions = new Dictionary<string, LegionDetails>();

            for (int i = 0; i < N; i++)
            {
                string[] args = Console.ReadLine().Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                long lastActivity = long.Parse(args[0]);
                string legionName = args[1];
                string soldierType = args[2];
                long soldiersCount = long.Parse(args[3]);

                // If the legion does not exist in the dictionary we add it:
                if (!legions.ContainsKey(legionName))
                {
                    LegionDetails currentLegion = new LegionDetails();
                    currentLegion.Activity = lastActivity;
                    currentLegion.soldiersTypeAndCout = new Dictionary<string, long>();
                    currentLegion.soldiersTypeAndCout[soldierType] = soldiersCount;
                    legions.Add(legionName, currentLegion);
                }
                else
                {
                    // If the legion exists in the dictionary but it does not have the current soldier type we add it:
                    if (!legions[legionName].soldiersTypeAndCout.ContainsKey(soldierType))
                    {
                        legions[legionName].soldiersTypeAndCout.Add(soldierType, soldiersCount);
                    }
                    else // If there is already such type we just add the soldiers count to it:
                    {
                        legions[legionName].soldiersTypeAndCout[soldierType] += soldiersCount;
                    }

                    // If the current activity is lower than the previous one we change it:
                    if (lastActivity > legions[legionName].Activity)
                    {
                        legions[legionName].Activity = lastActivity;
                    }
                }
            }

            string[] queryArgs = Console.ReadLine().Split('\\');

            if (queryArgs.Length > 1) // When the query has 2 arguments then we have "search activity" and "search soldier type":
            {
                long searchActivity = long.Parse(queryArgs[0]);
                string searchSoldierType = queryArgs[1];

                foreach (KeyValuePair<string, LegionDetails> entry in legions.Where(x => x.Value.soldiersTypeAndCout.ContainsKey(searchSoldierType) & x.Value.Activity < searchActivity).OrderByDescending(l => l.Value.soldiersTypeAndCout[searchSoldierType]))
                {
                    Console.WriteLine($"{entry.Key} -> {entry.Value.soldiersTypeAndCout[searchSoldierType]}");
                }
            }
            else
            {
                // If the argument is only one then we have only "search soldier type":
                string searchSoldierType = queryArgs[0];

                foreach (KeyValuePair<string, LegionDetails> entry in legions.Where(l => l.Value.soldiersTypeAndCout.ContainsKey(searchSoldierType)).OrderByDescending(l => l.Value.Activity))
                {
                    Console.WriteLine($"{entry.Value.Activity} : {entry.Key}");
                }
            }
        }
    }
}
