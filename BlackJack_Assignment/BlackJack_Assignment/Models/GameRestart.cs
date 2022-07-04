using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlackJack_Assignment.Models
{
    public class GameRestart
    {
        public void Restart()
        {
            Scores.Playerscore = 0;
            Scores.Dealerscore = 0;
            Scores.PlayerHitCount = 0;
            Scores.DealerHitCount = 0;
        }
    }
}