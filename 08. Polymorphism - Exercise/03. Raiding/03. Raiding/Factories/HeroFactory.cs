using Raiding.Factories.Interfaces;
using Raiding.Models;
using Raiding.Models.Interfaces;
using System;

namespace Raiding.Factories;

public class HeroFactory : IHeroFactory
{
    public IHero CreateHero(string type, string name)
    {
        if (type == "Druid")
        {
            return new Druid(name);
        }
        else if (type == "Paladin")
        {
            return new Paladin(name);
        }
        else if (type == "Rogue")
        {
            return new Rogue(name);
        }
        else if (type == "Warrior")
        {
            return new Warrior(name);
        }

        throw new ArgumentException("Invalid hero!");
    }
}