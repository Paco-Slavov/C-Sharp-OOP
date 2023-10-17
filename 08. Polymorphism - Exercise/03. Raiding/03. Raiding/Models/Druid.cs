using Raiding.Models.Abstract_Classes;

namespace Raiding.Models;

public class Druid : Hero
{
    private const int defaultPower = 80;

    public Druid(string name) : base(name) { }

    public override int Power => defaultPower;

    public override string CastAbility()
    {
        return base.CastAbility() + $" healed for {Power}";
    }
}