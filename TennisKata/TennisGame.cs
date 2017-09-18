using System;

namespace TennisKata
{
    public class TennisGame
    {
        private Player _playerOne;
        private Player _playerTwo;
        private ScoreState _score;

        public TennisGame()
        {
            _playerOne = Player.Player1;
            _playerTwo = Player.Player2;
            _score = new Points(Point.Love, Point.Love);
        }

        public TennisGame(ScoreState score) 
            : this ()
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
