namespace TennisKata
{
    public class Points : ScoreState
    {
        public Points(Point playerOnePoint, Point playerTwoPoint) : 
            base(playerOnePoint, playerTwoPoint)
        {
        }

        public override string ToString()
        {
            return _playerOnePoint + ":" + _playerTwoPoint;
        }
    }
}
