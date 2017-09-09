using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKataTest
{
    [TestFixture]
    class TennisTest
    {
        [Test]
        public void WhenPlayerOneWinPointScoreIsFiftyLove()
        {
            //Given the score 0:0
            var player1 = new Player("P1");
            var player2 = new Player("P2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);

            //When Player1 wins a point
            var score = game.DisplayPoint();

            //Then the score is 15:0
            Assert.AreEqual("15:0", score);
        }

        [Test]
        public void WhenPlayerTwoWinPointScoreIsFiftyThirty()
        {
            //Given the score 15:15
            var player1 = new Player("P1");
            var player2 = new Player("P2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player2);

            //when Player2 wins a point
            game.EarnPoint(player2);
            var score = game.DisplayPoint();

            //Then the score is 15:30
            Assert.AreEqual("15:30", score);
        }

        [Test]
        public void WhenPlayerOneWinPointScoreIsFortyThirty()
        {
            //Given the score 30:30 
            var player1 = new Player("P1");
            var player2 = new Player("P2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player2);
            game.EarnPoint(player2);

            //When Player1 wins a point
            game.EarnPoint(player1);
            var score = game.DisplayPoint();

            //Then the score is 40:30
            Assert.AreEqual("40:30", score);    
        }

        [Test]
        public void WhenPlayerTwoWinsPointScoreShouldBeFortyAdvantage()
        {
            //Given the score 40:40
            var player1 = new Player("P1");
            var player2 = new Player("P2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player2);
            game.EarnPoint(player2);
            game.EarnPoint(player2);

            //When Player1 wins a point
            game.EarnPoint(player2);
            var score = game.DisplayPoint();

            //Then the score is 40:Advantage
            Assert.AreEqual("40:Advantage", score);
        }

        [Test]
        public void WhenPlayerTwoWinsPointScoreShouldBeFortyForty()
        {
            //Given the score A:40
            var player1 = new Player("P1");
            var player2 = new Player("P2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player2);
            game.EarnPoint(player2);
            game.EarnPoint(player2);
            game.EarnPoint(player1);
            

            //When Player2 wins point
            game.EarnPoint(player2);
            var score = game.DisplayPoint();

            //Then the score is 40:40
            Assert.AreEqual("40:40", score);
        }

        [Test]
        public void WhenPlayerOneWinsPointPlayerOneShouldWin()
        {
            //Given the score 40:30
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player2);
            game.EarnPoint(player2);

            //When Player1 wins point
            game.EarnPoint(player1);
            var score = game.DisplayPoint();

            //Then the player1 should win
            Assert.AreEqual("Player1 win", score);
        }

        [Test]
        public void WhenPlayerTwoWinsPointPlayerTwoShouldWin()
        {
            //Given the score 40:Advantage
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");
            var game = new Game(player1, player2);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player1);
            game.EarnPoint(player2);
            game.EarnPoint(player2);
            game.EarnPoint(player2);
            game.EarnPoint(player2);

            //When Player2 wins point
            game.EarnPoint(player2);
            var score = game.DisplayPoint();

            //Then the player2 should win
            Assert.AreEqual("Player2 win", score);
        }

        static void Main(string[] args) {
        }
    }

    internal class Game
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

    internal class Player
    {
        private string _name;
        public int score { get;  set; }

        public Player(string name)
        {
            _name = name;
            score = 0;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
