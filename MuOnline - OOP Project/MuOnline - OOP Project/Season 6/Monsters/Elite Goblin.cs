namespace MuOnline.Season_6.Monsters;

public class EliteGoblin : Monster
{
    private const int EliteGoblinDamage = 38;
    private const int EliteGoblinHealth = 75;
    private const int EliteGoblinDefense = 13;

    public EliteGoblin()
    : base(EliteGoblinDamage,
           EliteGoblinHealth,
           EliteGoblinDefense)
    {

    }
}