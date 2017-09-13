using FluentAssertions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TennisKata;

namespace TennisKataTest
{
    [TestFixture]
    class TennisGameShould
    {
        private TennisGame game;

        [Test]
        public void ReturnScoreFifteenLoveWhenPlayerOneWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Love, Point.Love);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Fifteen:Love");
        }

        [Test]
        public void ReturnScoreFifteenThirtyWhenPlayerTwoWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Fifteen, Point.Fifteen);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Fifteen:Thirty");
        }

        [Test]
        public void ReturnScoreFortyFortyWhenPlayerOneWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Thirty, Point.Thirty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Forty:Thirty");
        }

        [Test]
        public void ReturnScoreFortyAdvantageWhenPlayerTwoWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Forty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Forty:Advantage");
        }

        [Test]
        public void ReturnScoreDeuceWhenPlayerTwoWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Advantage, Point.Forty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Deuce");
        }

        [Test]
        public void ReturnGameWinForPlayerOneWhenPlayerOneWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Thirty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Player1 game win");
        }

        [Test]
        public void ReturnGameWinForPlayerTwoWhenPlayerTwoWinAPoint()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Advantage);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Player2 game win");
        }
    }
}
