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
            game = new TennisGame("player1", "player2");

            var score = game.WinAPoint("player1");
            Console.WriteLine(score);

            score = game.WinAPoint("player1");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player1");
            Console.WriteLine(score);

            score = game.WinAPoint("player1");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player2");
            Console.WriteLine(score);

            score = game.WinAPoint("player1");
            Console.WriteLine(score);

            Console.WriteLine("Press enter to finish game...");
            Console.ReadLine();
        }
    }
}
