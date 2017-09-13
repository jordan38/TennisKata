using System;

namespace TennisKata
{
    public class TennisGame
    {
        private String _playerOne;
        private String _playerTwo;
        private ScoreState _score;

        public TennisGame(string playerOne, string playerTwo)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _score = new Points(Point.Love, Point.Love);
        }

        public TennisGame(string playerOne, string playerTwo, ScoreState score)
        {
            _playerOne = playerOne;
            _playerTwo = playerTwo;
            _score = score;
        }

        public ScoreState WinAPoint(string player)
        {
            return _score.AddPointTo(player);
        }
    }
}
