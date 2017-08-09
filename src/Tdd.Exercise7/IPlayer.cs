namespace Tdd.Exercise7
{
    public interface IPlayer
    {
        Hand RevealHand();
        int Wins { get; set; }
    }
}