namespace TennisKata
{
    public class Player
    {
        private string _name;
        public int score { get;  set; }

        public Player(string name)
        {
            _name = name;
            score = 0;
        }

        public override string ToString()
        {
            return _name;
        }

    }
}
