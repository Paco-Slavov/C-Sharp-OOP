using MuOnline.Season_6.Heroes.HeroesStatistics;

namespace MuOnline.Core.Factories.Interface;

public interface IHeroFactory
{
    IHero Create(string heroType, string username);
}
