using Raiding.Models.Abstract_Classes;
namespace Raiding.Models;

public class Warrior : Hero
{
    private const int defaultPower = 100;

    public Warrior(string name) : base(name) { }

    public override int Power => defaultPower;

    public override string CastAbility()
    {
        return base.CastAbility() + $" hit for {Power} damage";
    }
}