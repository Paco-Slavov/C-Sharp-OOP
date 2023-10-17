namespace MuOnline.Season_6.Monsters;

public class ChainScorpion : Monster
{
    private const int ChainScorpionDamage = 30;
    private const int ChainScorpionHealth = 55;
    private const int ChainScorpionDefense = 8;

    public ChainScorpion()
    : base(ChainScorpionDamage,
           ChainScorpionHealth,
           ChainScorpionDefense)
    {

    }
}