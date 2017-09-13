using System;

namespace TennisKata
{
    public class Game : ScoreState
    {
        private Player _playerWhoWin;

        public Game(Point playerOnePoint, Point playerTwoPoint)
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public Game(Point playerOnePoint, Point playerTwoPoint, Player player) 
            : this(playerOnePoint, playerTwoPoint)
        {
            _playerWhoWin = player;
        }

        public override ScoreState AddPointTo(Player player)
        {
            ScoreState score;

            if (player.Number.Equals(1))
            {
                score = new Points(PlayerOnePoint + 1, PlayerTwoPoint);
            } else
            {
                score = new Points(PlayerOnePoint, PlayerTwoPoint + 1);
            }

            return score;
        }

        public override string ToString()
        {
            return _playerWhoWin.ToString() + " game win";
        }
    }
}
