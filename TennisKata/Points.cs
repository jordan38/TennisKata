using System;

namespace TennisKata
{
    public class Points : ScoreState
    {
        public Points(Point playerOnePoint, Point playerTwoPoint) 
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public override ScoreState AddPointTo(Player player)
        {
            ScoreState score = null;

            var diffBetweenScore = Math.Abs((int)PlayerOnePoint - (int)PlayerTwoPoint);

            if (Math.Max((int)PlayerOnePoint, (int)PlayerTwoPoint) < 3)
            {
                if (player == Player.Player1)
                {
                    score = new Points(PlayerOnePoint + 1, PlayerTwoPoint);
                } else
                {
                    score = new Points(PlayerOnePoint, PlayerTwoPoint + 1);
                }
            } else 
            {
                if (diffBetweenScore == 0)
                {
                    score = new Advantage(PlayerOnePoint, Point.Advantage, player);
                } else if (diffBetweenScore >= 1)
                {
                    if (PlayerOnePoint > PlayerTwoPoint)
                    {
                        if (player == Player.Player1)
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
                        if (player == Player.Player2)
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
            return PlayerOnePoint + ":" + PlayerTwoPoint;
        }
    }
}
