using Raiding.Models.Abstract_Classes;
namespace Raiding.Models;

public class Paladin : Hero
{
    private const int defaultPower = 100;

    public Paladin(string name) : base(name) { }

    public override int Power => defaultPower;

    public override string CastAbility()
    {
        return base.CastAbility() + $" healed for {Power}";
    }
}