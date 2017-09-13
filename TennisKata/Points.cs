using System;

namespace TennisKata
{
    public class Points : ScoreState
    {
        public Points(Point playerOnePoint, Point playerTwoPoint) : 
            base(playerOnePoint, playerTwoPoint)
        {
        }

        public override ScoreState AddPointTo(string player)
        {
            ScoreState score = null;

            var diffBetweenScore = Math.Abs((int)_playerOnePoint - (int)_playerTwoPoint);

            if (Math.Max((int)_playerOnePoint, (int)_playerTwoPoint) < 3)
            {
                if (Equals(player, "Player1"))
                {
                    score = new Points(_playerOnePoint + 1, _playerTwoPoint);
                } else
                {
                    score = new Points(_playerOnePoint, _playerTwoPoint + 1);
                }
            } else 
            {
                if (diffBetweenScore == 0)
                {
                    if (Equals(player, "Player1"))
                    {
                        score = new Advantage(Point.Advantage, _playerTwoPoint, player);
                    }
                    else
                    {
                        score = new Advantage(_playerOnePoint, Point.Advantage, player);
                    }
                } else if (diffBetweenScore >= 1)
                {
                    if (_playerOnePoint > _playerTwoPoint)
                    {
                        if (Equals(player, "Player1"))
                        {
                            score = new Game(Point.Love, Point.Love, player);
                        }
                        else
                        {
                            score = new Deuce(Point.Forty, Point.Forty);
                        }
                    }
                    else
                    {
                        if (Equals(player, "Player2"))
                        {
                            score = new Game(Point.Love, Point.Love, player);
                        }
                        else
                        {
                            score = new Deuce(Point.Forty, Point.Forty);
                        }
                    }
                }
            }

            return score;
        }

        public override string ToString()
        {
            return _playerOnePoint + ":" + _playerTwoPoint;
        }
    }
}
