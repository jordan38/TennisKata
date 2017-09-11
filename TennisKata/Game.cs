﻿namespace TennisKata
{
    public class Game : ScoreState
    {
        public Game(Point playerOnePoint, Point playerTwoPoint)
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public override string ToString()
        {
            return "Game win";
        }
    }
}
