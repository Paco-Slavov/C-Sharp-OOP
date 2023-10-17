using MuOnline.Repositories.Interfaces;
using MuOnline.Season_6.Heroes.HeroesStatistics;
using MuOnline.Season_6.Validation;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace MuOnline.Repositories;

public class HeroRepository : IRepository<IHero>
{
    private readonly ICollection<IHero> heroes;

    public HeroRepository()
    {
        this.heroes = new List<IHero>();
    }
    public IReadOnlyCollection<IHero> Repository
        => this.heroes.ToImmutableArray();

    public void Add(IHero hero)
    {
        Validator.ThrowAnExceptionIfObjectIsNull(hero, nameof(hero));
        this.heroes.Add(hero);
    }

    public IHero Get(string hero)
    {
        var targetHero = this.heroes.
                FirstOrDefault(h => (h as IIdentifiable)?.Username == hero);

        Validator.ThrowAnExceptionIfObjectIsNull(targetHero, nameof(targetHero));

        return targetHero;
    }

    public bool Remove(IHero hero)
    {
        Validator.ThrowAnExceptionIfObjectIsNull(hero, nameof(hero));

        bool isRemoved = this.heroes.Remove(hero);
        return isRemoved;
    }
}
