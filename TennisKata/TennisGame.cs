using System;

namespace TennisKata
{
    public class TennisGame
    {
        private Player _playerOne;
        private Player _playerTwo;
        private ScoreState _score;

        public TennisGame(string playerOne, string playerTwo)
        {
            _playerOne = new Player(1, playerOne);
            _playerTwo = new Player(2, playerTwo);
            _score = new Points(Point.Love, Point.Love);
        }

        public TennisGame(string playerOne, string playerTwo, ScoreState score) 
            : this (playerOne, playerTwo)
        {
            _score = score;
        }

        public ScoreState PlayerOneWinAPoint()
        {
            return _score.AddPointTo(_playerOne);
        }

        public ScoreState PlayerTwoWinAPoint()
        {
            return _score = _score.AddPointTo(_playerTwo);
        }
    }
}
