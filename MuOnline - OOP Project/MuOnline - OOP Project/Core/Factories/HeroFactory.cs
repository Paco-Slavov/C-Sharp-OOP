using MuOnline.Core.Factories.Interface;
using MuOnline.Season_6.Heroes.HeroesStatistics;
using MuOnline.Season_6.Validation;
using System;
using System.Linq;
using System.Reflection;

namespace MuOnline.Core.Factories;

public class HeroFactory : IHeroFactory
{
    public IHero Create (string heroType, string username)
    {
        var heroName = heroType.ToLower();

        var type = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(x => x.Name.ToLower() == heroName);

        Validator.ThrowAnExceptionIfObjectIsNull(type, nameof(IHero));

        var hero = Activator.CreateInstance(type, username) as IHero;

        return hero;
    }
}
