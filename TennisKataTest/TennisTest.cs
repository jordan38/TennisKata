﻿using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisKata;

namespace TennisKataTest
{
    [TestFixture]
    class TennisTest
    {
        private Player player1;
        private Player player2;
        private IGame game;

        [SetUp]
        public void Setup()
        {
            player1 = new Player("Player1");
            player2 = new Player("Player2");
        }

        [Test]
        public void WhenPlayerOneWinPointScoreIsFiftyLove()
        {
            //Given the score 0:0
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
            game = new Game(player1, player2);
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
}
