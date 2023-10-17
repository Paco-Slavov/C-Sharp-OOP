namespace MuOnline.Season_6.Monsters;

public class BudgeDragon : Monster
{
    private const int BudgeDragonDamage = 30;
    private const int BudgeDragonHealth = 55;
    private const int BudgeDragonDefense = 8;

    public BudgeDragon()
    : base(BudgeDragonDamage,
           BudgeDragonHealth,
           BudgeDragonDefense)
    {

    }
}
