using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Assignment.Models
{
    public class PlayingGame
    {
        public string CheckGameStatus()
        {
            if (Scores.Playerscore > 21 && Scores.Dealerscore <= 21)
            {
                return "DealerWon,PlayerLoses";
            }
            else if (Scores.Dealerscore < 21 && Scores.Playerscore == 21)
            {
                return "PlayerWon,DealerLoses";
            }
            else if (Scores.Dealerscore > 21 && Scores.Playerscore < 21)
            {
                return "PlayerWon,DealerLoses";
            }
            else if (Scores.Playerscore == Scores.Dealerscore)
            {
                return "GameTie";
            }
            else if (Scores.Playerscore <= 21)
            {
                if (Scores.Playerscore < Scores.Dealerscore)
                {
                    return "PlayerWon, DealerLoses";
                }
                else
                {
                    return "DealerWon,PlayerLoses";
                }
            }
            return "Oops!!Something Went Wrong";
        }
    }
}