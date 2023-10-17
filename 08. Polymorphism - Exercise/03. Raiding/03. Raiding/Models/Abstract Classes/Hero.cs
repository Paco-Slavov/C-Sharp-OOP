using Raiding.Models.Interfaces;

namespace Raiding.Models.Abstract_Classes;

public abstract class Hero : IHero
{
    protected Hero(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }
    public abstract int Power { get; }

    public virtual string CastAbility()
    {
        return $"{this.GetType().Name} - {Name}";
    }
}