using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisKata
{
    class Program
    {
        private static Game game;

        static void Main(string[] args)
        {
            var player1 = new Player("Player1");
            var player2 = new Player("Player2");

            game = new Game(player1, player2);

            game.WinAPoint(player1);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player1);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player1);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player1);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());

            game.WinAPoint(player2);
            Console.WriteLine(game.DisplayScore());
        }
    }
}
