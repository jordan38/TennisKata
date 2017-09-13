namespace TennisKata
{
    public abstract class ScoreState
    {
        public readonly Point _playerOnePoint;
        public readonly Point _playerTwoPoint;

        public ScoreState(Point playerOnePoint, Point playerTwoPoint)
        {
            _playerOnePoint = playerOnePoint;
            _playerTwoPoint = playerTwoPoint;
        }

        public abstract ScoreState AddPointTo(string player);
    }
}
