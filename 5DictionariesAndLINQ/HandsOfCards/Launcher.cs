using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    public class Launcher
    {
        public static void Main()
        {
            Dictionary<string, List<string>> playersAndCards = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(':');
            string playerName = input[0];

            while (!playerName.Contains("JOKER"))
            {
                List<string> cards = input[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!playersAndCards.ContainsKey(playerName))
                {
                    playersAndCards[playerName] = cards;
                }
                else
                {
                    playersAndCards[playerName].AddRange(cards);
                }

                input = Console.ReadLine().Split(':');
                playerName = input[0];
            }

            foreach (KeyValuePair<string, List<string>> player in playersAndCards)
            {
                int playerScore = 0;

                foreach (string singleCard in player.Value.Distinct())
                {
                    string cardRank = singleCard.Substring(0, singleCard.Length - 1);
                    string cardSuit = singleCard.Substring(singleCard.Length - 1);

                    int rankPower = GetRankPower(cardRank);
                    int suitPower = GetSuitPower(cardSuit);

                    playerScore += rankPower * suitPower;
                }

                Console.WriteLine($"{player.Key}: {playerScore}");
            }
        }

        public static int GetRankPower(string rank)
        {
            switch (rank)
            {
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                case "5":
                    return 5;
                case "6":
                    return 6;
                case "7":
                    return 7;
                case "8":
                    return 8;
                case "9":
                    return 9;
                case "10":
                    return 10;
                case "J":
                    return 11;
                case "Q":
                    return 12;
                case "K":
                    return 13;
                case "A":
                    return 14;
                default:
                    return 1;
            }
        }

        public static int GetSuitPower(string suit)
        {
            switch (suit)
            {
                case "S":
                    return 4;
                case "H":
                    return 3;
                case "D":
                    return 2;
                case "C":
                    return 1;
                default:
                    return 1;
            }
        }
    }
}
