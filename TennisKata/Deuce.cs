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
            return new Advantage(Point.Advantage, Point.Forty, player);
        }

        public override string ToString()
        {
            return "Deuce";
        }
    }
}
