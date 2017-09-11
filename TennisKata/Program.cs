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

            game.WinAPoint("player1");

            game.WinAPoint("player1");

            game.WinAPoint("player2");

            game.WinAPoint("player2");

            game.WinAPoint("player2");

            game.WinAPoint("player1");

            game.WinAPoint("player1");

            game.WinAPoint("player2");

            game.WinAPoint("player2");

            game.WinAPoint("player2");
        }
    }
}
