using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Hands_of_Cards
{
    public class Hands_of_Cards
    {
        public static void Main()
        {
            Dictionary<string, List<string>> playerCards = new Dictionary<string, List<string>>();

            char[] splitters = { ':', ',', ' ' };

            string[] playerInformation = Console.ReadLine().Split(':').Distinct().ToArray();

            while (!playerInformation[0].Equals("JOKER"))
            {
                if (!playerCards.ContainsKey(playerInformation[0]))
                {
                    playerCards.Add(playerInformation[0], new List<string>());
                }

                string[] cards = playerInformation[1].
                    Split(splitters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < cards.Length; i++)
                {
                    if (!playerCards[playerInformation[0]].Contains(cards[i]))
                    {
                        playerCards[playerInformation[0]].Add(cards[i]);
                    }
                }

                playerInformation = Console.ReadLine().Split(':').Distinct().ToArray();
            }

            Dictionary<string, int> playerScore = new Dictionary<string, int>();

            foreach (KeyValuePair<string, List<string>> cardsInfo in playerCards)
            {
                if (!playerScore.ContainsKey(cardsInfo.Key))
                {
                    playerScore.Add(cardsInfo.Key, 0);
                }

                for (int i = 0; i < cardsInfo.Value.Count; i++)
                {
                    int power = GetPowerValue(cardsInfo.Value[i][0]);

                    int multiplier = 1;

                    if (cardsInfo.Value[i][0] == '1')
                    {
                        multiplier = GetTypeMultiplier(cardsInfo.Value[i][2]);
                    }

                    else
                    {
                        multiplier = GetTypeMultiplier(cardsInfo.Value[i][1]);
                    }

                    int totalScore = power * multiplier;

                    playerScore[cardsInfo.Key] += totalScore;
                }
            }

            foreach (KeyValuePair<string, int> playerInfo in playerScore)
            {
                Console.WriteLine($"{playerInfo.Key}: {playerInfo.Value}");
            }
        }

        static int GetPowerValue(char power)
        {
            int value = 0;

            switch (power)
            {
                case '2':
                    value = 2;
                    break;

                case '3':
                    value = 3;
                    break;

                case '4':
                    value = 4;
                    break;

                case '5':
                    value = 5;
                    break;

                case '6':
                    value = 6;
                    break;

                case '7':
                    value = 7;
                    break;

                case '8':
                    value = 8;
                    break;

                case '9':
                    value = 9;
                    break;

                case '1':
                    value = 10;
                    break;

                case 'J':
                    value = 11;
                    break;

                case 'Q':
                    value = 12;
                    break;

                case 'K':
                    value = 13;
                    break;

                case 'A':
                    value = 14;
                    break;
            }

            return value;
        }

        static int GetTypeMultiplier(char type)
        {
            int multiplier = 0;

            switch (type)
            {
                case 'S':
                    multiplier = 4;
                    break;

                case 'H':
                    multiplier = 3;
                    break;

                case 'D':
                    multiplier = 2;
                    break;

                case 'C':
                    multiplier = 1;
                    break;
            }

            return multiplier;
        }
    }
}
