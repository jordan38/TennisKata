using System;

namespace TennisKata
{
    public class Advantage : ScoreState
    {
        private string _playerWithAdvantage;

        public Advantage(Point playerOnePoint, Point playerTwoPoint) : base(playerOnePoint, playerTwoPoint)
        {
        }

        public Advantage(Point playerOnePoint, Point playerTwoPoint, string playerWithAdvantage) : this(playerOnePoint, playerTwoPoint)
        {
            _playerWithAdvantage = playerWithAdvantage;
        }

        public override ScoreState AddPointTo(string player)
        {
            ScoreState score;

            if (_playerOnePoint > _playerTwoPoint)
            {
                if (Equals(player, "Player1"))
                {
                    score = new Game(Point.Love, Point.Love, player);
                } else
                {
                    score = new Deuce(Point.Forty, Point.Forty);
                }
            }
            else
            {
                if (Equals(player, "Player2"))
                {
                    score = new Game(Point.Love, Point.Love, player);
                } else
                {
                    score = new Deuce(Point.Forty, Point.Forty);
                }
            }

            return score;
        }

        public override string ToString()
        {
            return "Advantage for " + _playerWithAdvantage; 
        }
    }
}
