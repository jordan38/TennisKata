namespace TennisKata
{
    public class Deuce : ScoreState
    {
        public Deuce(Point playerOnePoint, Point playerTwoPoint) 
            : base(playerOnePoint, playerTwoPoint)
        {
        }

        public override string ToString()
        {
            return "Deuce";
        }
    }
}
