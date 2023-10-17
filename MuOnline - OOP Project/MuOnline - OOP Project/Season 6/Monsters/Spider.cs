namespace MuOnline.Season_6.Monsters;

public class Spider : Monster
{
    private const int SpiderDamage = 25;
    private const int SpiderHealth = 50;
    private const int SpiderDefense = 5;

    public Spider()
    : base(SpiderDamage,
           SpiderHealth,
           SpiderDefense)
    {

    }
}
