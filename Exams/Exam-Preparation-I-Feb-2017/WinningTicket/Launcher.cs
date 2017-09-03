using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    public class Launcher
    {
        public static void Main()
        {
            string[] inputTickets = Regex.Split(Console.ReadLine(), @"\s*,\s+");
            Dictionary<string, string> ticketsAndAwards = new Dictionary<string, string>();

            string winnerPattern = @"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}";
            string jackpotPattern = @"[@]{10}|[#]{10}|[$]{10}|[\^]{10}";

            foreach (string ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    ticketsAndAwards.Add(ticket, "invalid ticket");
                }
                else
                {
                    string leftPart = ticket.Substring(0, 10);
                    string rightPart = ticket.Substring(10, 10);

                    Match jackpotLeft = Regex.Match(leftPart, jackpotPattern);
                    Match jackpotRight = Regex.Match(rightPart, jackpotPattern);

                    Match winnerLeft = Regex.Match(leftPart, winnerPattern);
                    Match winnerRight = Regex.Match(rightPart, winnerPattern);

                    if (jackpotLeft.Success && jackpotRight.Success && jackpotLeft.ToString()[0].Equals(jackpotRight.ToString()[0]))
                    {
                        char winningSymbol = jackpotLeft.ToString()[0];

                        ticketsAndAwards.Add(ticket, $"10{winningSymbol} Jackpot!");
                    }
                    else if (winnerLeft.Success && winnerRight.Success && winnerLeft.ToString()[0].Equals(winnerRight.ToString()[0]))
                    {
                        char winningSymbol = winnerLeft.ToString()[0];
                        int prize = Math.Min(winnerLeft.Length, winnerRight.Length);

                        ticketsAndAwards.Add(ticket, prize.ToString() + winningSymbol);
                    }
                    else
                    {
                        ticketsAndAwards.Add(ticket, "no match");
                    }
                }
            }

            foreach (KeyValuePair<string, string> ticket in ticketsAndAwards)
            {
                if (ticket.Value.Equals("invalid ticket"))
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket.Key}\" - {ticket.Value}");
                }
            }
        }
    }
}
