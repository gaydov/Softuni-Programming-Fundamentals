using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    public class TeamworkProjects
    {
        public static void Main()
        {
            int teamsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Team> teamsDatabase = new Dictionary<string, Team>();

            CreatingTeams(teamsCount, teamsDatabase);

            PopulatingTeams(teamsDatabase);

            PrintingTeamsAndMembers(teamsDatabase);
        }

        public static void CreatingTeams(int count, Dictionary<string, Team> teams)
        {
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                string creatorOfTeam = input[0];
                string nameOfTeam = input[1];

                if (teams.Keys.Contains(nameOfTeam))
                {
                    Console.WriteLine($"Team {nameOfTeam} was already created!");
                }
                else if (teams.Values
                    .Select(t => t.Creator)
                    .Contains(creatorOfTeam))
                {
                    Console.WriteLine($"{creatorOfTeam} cannot create another team!");
                }
                else
                {
                    teams[nameOfTeam] = new Team
                    {
                        Creator = creatorOfTeam,
                        Members = new List<string>()
                    };

                    Console.WriteLine($"Team {nameOfTeam} has been created by {creatorOfTeam}!");
                }
            }
        }

        public static void PopulatingTeams(Dictionary<string, Team> teams)
        {
            string input = Console.ReadLine();

            while (!input.Equals("end of assignment"))
            {
                string[] userAndTeam = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string user = userAndTeam[0];
                string desiredTeam = userAndTeam[1];

                if (!teams.Keys.Contains(desiredTeam))
                {
                    Console.WriteLine($"Team {desiredTeam} does not exist!");
                }
                else if (teams.Values
                    .Select(t => t.Members)
                    .Any(m => m.Contains(user)) 
                    || teams.Values
                    .Select(t => t.Creator)
                    .Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {desiredTeam}!");
                }
                else
                {
                    teams[desiredTeam].Members.Add(user);
                }

                input = Console.ReadLine();
            }
        }

        public static void PrintingTeamsAndMembers(Dictionary<string, Team> teams)
        {
            var validTeams = teams
                .Where(t => t.Value.Members.Count > 0)
                .OrderByDescending(t => t.Value.Members.Count)
                .ThenBy(t => t.Key);

            foreach (KeyValuePair<string, Team> validTeam in validTeams)
            {
                Console.WriteLine($"{validTeam.Key}");
                Console.WriteLine($"- {validTeam.Value.Creator}");

                foreach (string member in validTeam.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandedTeams = teams
                .Where(t => t.Value.Members.Count == 0)
                .OrderBy(t => t.Key);

            Console.WriteLine("Teams to disband:");
            foreach (KeyValuePair<string, Team> disbandedTeam in disbandedTeams)
            {
                Console.WriteLine($"{disbandedTeam.Key}");
            }
        }
    }

    public class Team
    {
        public string TeamName { get; set; }

        public List<string> Members { get; set; }

        public string Creator { get; set; }
    }
}
