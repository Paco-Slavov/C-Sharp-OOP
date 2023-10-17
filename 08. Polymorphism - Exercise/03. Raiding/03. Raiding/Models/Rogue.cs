using Raiding.Models.Abstract_Classes;
namespace Raiding.Models;

public class Rogue : Hero
{
    private const int defaultPower = 80;

    public Rogue(string name) : base(name) { }

    public override int Power => defaultPower;

    public override string CastAbility()
    {
        return base.CastAbility() + $" hit for {Power} damage";
    }
}