namespace MuOnline.Season_6.Monsters;

public class Goblin : Monster
{
    private const int GoblinDamage = 25;
    private const int GoblinHealth = 50;
    private const int GoblinDefense = 5;

    public Goblin()
    : base(GoblinDamage,
           GoblinHealth,
           GoblinDefense)
    {

    }
}