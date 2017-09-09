using TennisKata;

namespace TennisKata
{
    public interface IGame
    {
        string DisplayPoint();
        void EarnPoint(Player player);
    }
}