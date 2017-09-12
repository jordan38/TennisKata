namespace TennisKata
{
    public class Game : ScoreState
    {
        private string _player;

        public Game(Point playerOnePoint, Point playerTwoPoint)
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public Game(Point playerOnePoint, Point playerTwoPoint, string player) : this(playerOnePoint, playerTwoPoint)
        {
            _player = player;
        }

        public override string ToString()
        {
            return _player + " game win";
        }
    }
}
