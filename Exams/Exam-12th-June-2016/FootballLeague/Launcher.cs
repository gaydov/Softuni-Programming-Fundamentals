using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    public class Launcher
    {
        public static void Main()
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            Dictionary<string, int> teamAndScore = new Dictionary<string, int>();
            Dictionary<string, int> teamAndGoals = new Dictionary<string, int>();

            while (!input.Equals("final"))
            {
                int firstIndKeyFirstTeam = input.IndexOf(key);
                int secondIndKeyFirstTeam = input.IndexOf(key, firstIndKeyFirstTeam + key.Length);

                char[] firstTeamChars = input.Substring(firstIndKeyFirstTeam + key.Length, secondIndKeyFirstTeam - firstIndKeyFirstTeam - key.Length)
                    .Reverse()
                    .ToArray();
                string firstTeam = new string(firstTeamChars).ToUpper();

                int firstIndKeySecondTeam = input.IndexOf(key, secondIndKeyFirstTeam + key.Length);
                int secondIndKeySecondTeam = input.IndexOf(key, firstIndKeySecondTeam + key.Length);

                char[] secondTeamChars = input.Substring(firstIndKeySecondTeam + key.Length, secondIndKeySecondTeam - firstIndKeySecondTeam - key.Length)
                    .Reverse()
                    .ToArray();
                string secondTeam = new string(secondTeamChars).ToUpper();

                string[] lineArgs = input.Split();
                int[] goals = lineArgs[lineArgs.Length - 1].Split(':').Select(int.Parse).ToArray();

                EnterScores(teamAndScore, goals, firstTeam, secondTeam);

                EnterGoals(teamAndGoals, goals, firstTeam, secondTeam);

                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            int place = 1;

            foreach (KeyValuePair<string, int> team in teamAndScore.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine("{0}. {1} {2}", place, team.Key, team.Value);
                place++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (KeyValuePair<string, int> team in teamAndGoals.OrderByDescending(t => t.Value).ThenBy(t => t.Key).Take(3))
            {
                Console.WriteLine("- {0} -> {1}", team.Key, team.Value);
            }
        }

        public static void EnterGoals(Dictionary<string, int> teamsGoals, int[] goalsInGame, string firstTeam, string secondTeam)
        {
            if (!teamsGoals.ContainsKey(firstTeam))
            {
                teamsGoals.Add(firstTeam, goalsInGame[0]);
            }
            else
            {
                teamsGoals[firstTeam] += goalsInGame[0];
            }

            if (!teamsGoals.ContainsKey(secondTeam))
            {
                teamsGoals.Add(secondTeam, goalsInGame[1]);
            }
            else
            {
                teamsGoals[secondTeam] += goalsInGame[1];
            }
        }

        public static void EnterScores(Dictionary<string, int> teamsScores, int[] goalsInGame, string firstTeam, string secondTeam)
        {
            int scoreFirstTeam = 0;
            int scoreSecondTeam = 0;

            if (goalsInGame[0] > goalsInGame[1])
            {
                scoreFirstTeam = 3;
                scoreSecondTeam = 0;
            }
            else if (goalsInGame[1] > goalsInGame[0])
            {
                scoreSecondTeam = 3;
                scoreFirstTeam = 0;
            }
            else
            {
                scoreFirstTeam = 1;
                scoreSecondTeam = 1;
            }

            if (!teamsScores.ContainsKey(firstTeam))
            {
                teamsScores.Add(firstTeam, scoreFirstTeam);
            }
            else
            {
                teamsScores[firstTeam] += scoreFirstTeam;
            }

            if (!teamsScores.ContainsKey(secondTeam))
            {
                teamsScores.Add(secondTeam, scoreSecondTeam);
            }
            else
            {
                teamsScores[secondTeam] += scoreSecondTeam;
            }
        }
    }
}
