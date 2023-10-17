namespace MuOnline.Season_6.Monsters.MonstersStatistics;
public interface IMonster
{
    int Damage { get; }
    int Health { get; }
    int Defense { get; }
    bool IsAlive { get; }


}
