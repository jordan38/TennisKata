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
        {
            _playerOne = new Player(1, playerOne);
            _playerTwo = new Player(2, playerTwo);
            _score = score;
        }

        public ScoreState WinAPoint(string player)
        {
            if (Equals(_playerOne.Name, player))
            {
                _score = _score.AddPointTo(_playerOne);
            } else
            {
                _score = _score.AddPointTo(_playerTwo);
            }

            return _score;
        }
    }

    public class Player
    {
        public readonly int Numero;
        public readonly String Name;

        public Player(int numero, string name)
        {
            Numero = numero;
            Name = name;
        }

        public override string ToString()
        {
            return "Player" + Numero;
        }
    }
}
