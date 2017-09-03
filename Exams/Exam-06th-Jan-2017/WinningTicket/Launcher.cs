using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    public class Launcher
    {
        public static void Main()
        {
            string[] inputTickets = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, string> ticketWithPrize = new Dictionary<string, string>();

            foreach (string ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    ticketWithPrize.Add(ticket, "invalid");
                }
                else
                {
                    string firstHalf = ticket.Substring(0, 10);
                    string secondHalf = ticket.Substring(10, 10);

                    Regex jackpotRegex = new Regex(@"[@]{10}|[#]{10}|[$]{10}|[\^]{10}");
                    Match firstHalfJackpotMatch = jackpotRegex.Match(firstHalf);
                    Match secondHalfJackpotMatch = jackpotRegex.Match(secondHalf);
                    string firstHalfJackpot = firstHalfJackpotMatch.ToString();
                    string secondHalfJackpot = secondHalfJackpotMatch.ToString();

                    // For a jackpot we need to have 2 successful matches and both strings of the matches to be equal:
                    if ((firstHalfJackpotMatch.Success && secondHalfJackpotMatch.Success) && firstHalfJackpot.Equals(secondHalfJackpot))
                    {
                        char winningSymbol = firstHalfJackpot[0];
                        ticketWithPrize.Add(ticket, $"10{winningSymbol} Jackpot!");
                    }
                    else
                    {
                        Regex winnerPattern = new Regex(@"[@]{6,9}|[#]{6,9}|[$]{6,9}|[\^]{6,9}");
                        Match firstHalfWinnerMatch = winnerPattern.Match(firstHalf);
                        Match secondHalfWinnerMatch = winnerPattern.Match(secondHalf);
                        string firstHalfWinner = firstHalfWinnerMatch.ToString();
                        string secondHalfWinner = secondHalfWinnerMatch.ToString();

                        // If we have 2 successful matches and also if the matches are from the same symbols we consider the ticket legit and its prize is the shorter one's length:
                        if ((firstHalfWinnerMatch.Success && secondHalfWinnerMatch.Success) && firstHalfWinner[0].Equals(secondHalfWinner[0]))
                        {
                            int prizeSize = Math.Min(firstHalfWinner.Length, secondHalfWinner.Length);
                            char winningSymbol = firstHalfWinner[0];
                            ticketWithPrize.Add(ticket, $"{prizeSize}{winningSymbol}");
                        }
                        else
                        {
                            ticketWithPrize.Add(ticket, "no match");
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, string> ticket in ticketWithPrize)
            {
                if (ticket.Value.Equals("invalid"))
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
