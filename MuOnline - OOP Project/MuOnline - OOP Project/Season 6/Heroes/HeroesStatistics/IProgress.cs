namespace MuOnline.Season_6.Heroes.HeroesStatistics;

public interface IProgress
{
    double Experience { get; }
    int Level { get; }
    int Resets { get; }
}
