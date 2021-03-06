﻿using System;

namespace TennisKata
{
    public class Advantage : ScoreState
    {
        private Player _playerWithAdvantage;

        public Advantage(Point playerOnePoint, Point playerTwoPoint) 
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public Advantage(Point playerOnePoint, Point playerTwoPoint, Player playerWithAdvantage) 
            : this(playerOnePoint, playerTwoPoint)
        {
            _playerWithAdvantage = playerWithAdvantage;
        }

        public override ScoreState AddPointTo(Player player)
        {
            ScoreState score;

            if (player == _playerWithAdvantage)
            {
                score = new Game(Point.Love, Point.Love, player);
            } else
            {
                score = new Deuce(Point.Forty, Point.Forty);
            }

            return score;
        }

        public override string ToString()
        {
            return "Advantage for " + _playerWithAdvantage; 
        }
    }
}
