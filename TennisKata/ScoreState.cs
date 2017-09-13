namespace TennisKata
{
    public abstract class ScoreState
    {
        public readonly Point PlayerOnePoint;
        public readonly Point PlayerTwoPoint;

        public ScoreState(Point playerOnePoint, Point playerTwoPoint)
        {
            PlayerOnePoint = playerOnePoint;
            PlayerTwoPoint = playerTwoPoint;
        }

        public abstract ScoreState AddPointTo(Player player);
    }
}
