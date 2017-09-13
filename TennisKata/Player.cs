using System;

namespace TennisKata
{
    public class Player
    {
        public readonly int Number;
        public readonly String Name;

        public Player(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public override string ToString()
        {
            return "Player" + Number;
        }
    }
}
