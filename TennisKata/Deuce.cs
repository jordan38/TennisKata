using System;

namespace TennisKata
{
    public class Deuce : ScoreState
    {
        public Deuce(Point playerOnePoint, Point playerTwoPoint) 
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public override ScoreState AddPointTo(Player player)
        {
            ScoreState score;

            if (player == Player.Player1)
            {
                score = new Advantage(Point.Advantage, Point.Forty, player);
            } else
            {
                score = new Advantage(Point.Forty, Point.Advantage, player);
            }

            return score;
        }

        public override string ToString()
        {
            return "Deuce";
        }
    }
}
