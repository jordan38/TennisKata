using System;
using TennisKata;

namespace TennisKata
{
    public class Game : IGame
    {
        private Player _player1;
        private Player _player2;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void EarnPoint(Player player)
        {
            player.score += 1;
            if (_player1.score > 3 || _player2.score > 3 )
            {
                var diffBetweenScore = Math.Abs(_player1.score - _player2.score);
                if (diffBetweenScore == 0)
                {
                    _player1.score = 3;
                    _player2.score = 3;

                } else if (diffBetweenScore > 1)
                {
                    player.score += 2;
                }

            }
             
        }

        public String DisplayPoint()
        {
            var display = "";

            var p1ScoreDisplay = TranslatePoint(_player1);
            var separator = ":";
            var p2ScoreDisplay = TranslatePoint(_player2);

            if (p1ScoreDisplay.Contains("win"))
            {
                display = p1ScoreDisplay;

            } else if (p2ScoreDisplay.Contains("win"))
            {
                display = p2ScoreDisplay;
            } else
            {
                display = p1ScoreDisplay + separator + p2ScoreDisplay;
            }

            return display;
        }

        private string TranslatePoint(Player player)
        {
            var point = "";

            switch(player.score)
            {
                case 0:
                    point = "0";
                    break;
                case 1:
                    point = "15";
                    break;
                case 2:
                    point = "30";
                    break;
                case 3:
                    point = "40";
                    break;
                case 4:
                    point = "Advantage";
                    break;
                default:
                    point = player.ToString() + " win";
                    break;
            }
            return point;
        }
    }
}
