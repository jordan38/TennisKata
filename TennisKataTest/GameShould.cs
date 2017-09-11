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
        public void WhenPlayerOneWinPointScoreIsFiftyLove()
        {
            ScoreState scoreStart = new Points(Point.Love, Point.Love);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Fifteen:Love");
        }

        [Test]
        public void WhenPlayerTwoWinPointScoreIsFiftyThirty()
        {
            ScoreState scoreStart = new Points(Point.Fifteen, Point.Fifteen);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Fifteen:Thirty");
        }

        [Test]
        public void WhenPlayerOneWinPointScoreIsFortyThirty()
        {
            ScoreState scoreStart = new Points(Point.Thirty, Point.Thirty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Forty:Thirty");
        }

        [Test]
        public void WhenPlayerTwoWinsPointScoreShouldBeFortyAdvantage()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Forty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Forty:Advantage");
        }

        [Test]
        public void WhenPlayerTwoWinsPointScoreShouldBeFortyForty()
        {
            ScoreState scoreStart = new Points(Point.Advantage, Point.Forty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Deuce");
        }

        [Test]
        public void WhenPlayerOneWinsPointPlayerOneShouldWin()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Thirty);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player1");

            score.ToString().Should().Be("Game win");
        }

        [Test]
        public void WhenPlayerTwoWinsPointPlayerTwoShouldWin()
        {
            ScoreState scoreStart = new Points(Point.Forty, Point.Advantage);
            game = new TennisGame("Player1", "Player2", scoreStart);

            var score = game.WinAPoint("Player2");

            score.ToString().Should().Be("Game win");
        }
    }
}
