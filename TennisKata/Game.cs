using System;

namespace TennisKata
{
    public class Game : ScoreState
    {
        private string _player;

        public Game(Point playerOnePoint, Point playerTwoPoint)
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public Game(Point playerOnePoint, Point playerTwoPoint, string player) : this(playerOnePoint, playerTwoPoint)
        {
            _player = player;
        }

        public override ScoreState AddPointTo(string player)
        {
            ScoreState score;

            if (Equals(player, "Player1"))
            {
                score = new Points(_playerOnePoint + 1, _playerTwoPoint);
            } else
            {
                score = new Points(_playerOnePoint, _playerTwoPoint + 1);
            }

            return score;
        }

        public override string ToString()
        {
            return _player + " game win";
        }
    }
}
