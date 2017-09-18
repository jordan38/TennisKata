using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    class Program
    {
        private static TennisGame game;

        static void Main(string[] args)
        {
            game = new TennisGame();

            var score = game.PlayerOneWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerOneWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerOneWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerOneWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerTwoWinAPoint();
            Console.WriteLine(score);

            score = game.PlayerOneWinAPoint();
            Console.WriteLine(score);

            Console.WriteLine("Press enter to finish game...");
            Console.ReadLine();
        }
    }
}
