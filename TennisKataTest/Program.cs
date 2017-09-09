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

        static void Main(string[] args) {
        }
    }

    internal class Game
    {
        private Player player1;
        private Player player2;

        public Game(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public void EarnPoint(Player player)
        {
            player._score += 1;
        }

        public String DisplayPoint()
        {
            var display = "";

            display += TranslatePoint(player1._score);
            display += ":";
            display += TranslatePoint(player2._score);

            return display;
        }

        private string TranslatePoint(int score)
        {
            var point = "";

            switch(score)
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
            }
            return point;
        }
    }

    internal class Player
    {
        private string _name;
        public int _score { get;  set; }

        public Player(string name)
        {
            this._name = name;
            this._score = 0;
        }
    }
}
