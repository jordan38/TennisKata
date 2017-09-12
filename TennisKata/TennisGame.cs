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
            if (Equals(player, _playerOne))
            {
                _score = new Points(_score._playerOnePoint + 1, _score._playerTwoPoint);
            }
            else
            {
                _score = new Points(_score._playerOnePoint, _score._playerTwoPoint + 1);
            }

            var diffBetweenScore = Math.Abs((int)_score._playerOnePoint - (int)_score._playerTwoPoint);

            if (Math.Max((int)_score._playerOnePoint, (int)_score._playerTwoPoint) > (int)Point.Forty)
            {
                if (diffBetweenScore == 0)
                {
                    _score = new Deuce(Point.Forty, Point.Forty);
                }
                else if (diffBetweenScore >= 2)
                {
                    if ((int)_score._playerOnePoint > (int)_score._playerTwoPoint)
                    {
                        _score = new Game(Point.Love, Point.Love, _playerOne);
                    } else
                    {
                        _score = new Game(Point.Love, Point.Love, _playerTwo);
                    }
                }
            }
            return _score;
        }
    }
}
