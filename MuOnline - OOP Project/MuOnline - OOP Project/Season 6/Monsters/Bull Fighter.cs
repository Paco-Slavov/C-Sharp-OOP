namespace MuOnline.Season_6.Monsters;

public class BullFighter : Monster
{
    private const int BullFighterDamage = 38;
    private const int BullFighterHealth = 75;
    private const int BullFighterDefense = 13;

    public BullFighter()
    : base(BullFighterDamage,
           BullFighterHealth,
           BullFighterDefense)
    {

    }
}