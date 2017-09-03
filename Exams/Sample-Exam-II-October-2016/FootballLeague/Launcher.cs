using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<string, int> teamsScores = new Dictionary<string, int>();
            Dictionary<string, int> teamsGoals = new Dictionary<string, int>();

            string key = Console.ReadLine();

            string[] input = Console.ReadLine().Split();

            while (!input[0].Equals("final"))
            {
                int keyFirstTeamFirstIndex = input[0].IndexOf(key);
                int keyFirstTeamSecondIndex = input[0].IndexOf(key, keyFirstTeamFirstIndex + key.Length);
                char[] firstTeamArr = input[0].Substring(keyFirstTeamFirstIndex + key.Length, keyFirstTeamSecondIndex - (keyFirstTeamFirstIndex + key.Length)).Reverse().ToArray();

                string firstTeam = new string(firstTeamArr).ToUpper();

                int keySeconTeamFirstIndex = input[1].IndexOf(key);
                int keySecodTeamSecondIndex = input[1].IndexOf(key, keySeconTeamFirstIndex + key.Length);
                char[] secondTeamArr = input[1].Substring(keySeconTeamFirstIndex + key.Length, keySecodTeamSecondIndex - (keySeconTeamFirstIndex + key.Length)).Reverse().ToArray();

                string secondTeam = new string(secondTeamArr).ToUpper();

                int[] goalsPerGame = input[2].Split(':').Select(int.Parse).ToArray();
                int firstTeamGoals = goalsPerGame[0];
                int secondTeamGoals = goalsPerGame[1];

                int firstTeamPoints = 0;
                int secondTeamPoints = 0;

                if (firstTeamGoals > secondTeamGoals)
                {
                    firstTeamPoints = 3;
                    secondTeamPoints = 0;
                }
                else if (secondTeamGoals > firstTeamGoals)
                {
                    secondTeamPoints = 3;
                    firstTeamPoints = 0;
                }
                else
                {
                    firstTeamPoints = 1;
                    secondTeamPoints = 1;
                }

                EnterTeamsPoints(teamsScores, firstTeam, secondTeam, firstTeamPoints, secondTeamPoints);
                EnterTeamsGoals(teamsGoals, firstTeam, secondTeam, firstTeamGoals, secondTeamGoals);

                input = Console.ReadLine().Split();
            }

            Console.WriteLine("League standings:");
            int place = 1;

            foreach (KeyValuePair<string, int> team in teamsScores.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (KeyValuePair<string, int> team in teamsGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value}");
            }
        }

        public static void EnterTeamsGoals(Dictionary<string, int> teamsGoals, string firstTeam, string secondTeam, int firstTeamGoals, int secondTeamGoals)
        {
            if (!teamsGoals.ContainsKey(firstTeam))
            {
                teamsGoals.Add(firstTeam, firstTeamGoals);
            }
            else
            {
                teamsGoals[firstTeam] += firstTeamGoals;
            }

            if (!teamsGoals.ContainsKey(secondTeam))
            {
                teamsGoals.Add(secondTeam, secondTeamGoals);
            }
            else
            {
                teamsGoals[secondTeam] += secondTeamGoals;
            }
        }

        public static void EnterTeamsPoints(Dictionary<string, int> teamsScores, string firstTeam, string secondTeam, int firstTeamPoints, int secondTeamPoints)
        {
            if (!teamsScores.ContainsKey(firstTeam))
            {
                teamsScores.Add(firstTeam, firstTeamPoints);
            }
            else
            {
                teamsScores[firstTeam] += firstTeamPoints;
            }

            if (!teamsScores.ContainsKey(secondTeam))
            {
                teamsScores.Add(secondTeam, secondTeamPoints);
            }
            else
            {
                teamsScores[secondTeam] += secondTeamPoints;
            }
        }
    }
}
