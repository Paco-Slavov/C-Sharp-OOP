using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using PlanetWars.Utilities.Messages;
using PlanetWars_02.Models.MilitaryUnits.Entities;
using PlanetWars_02.Models.Weapons.Entities;
using PlanetWars_02.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace PlanetWars_02.Models.Planets;

public class Planet : IPlanet
{
    private string name;
    private double budget;
    private UnitRepository units;
    private WeaponRepository weapons;

    public Planet(string name, double budget)
    {
        Name = name;
        Budget = budget;
        units = new UnitRepository();
        weapons = new WeaponRepository();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidPlanetName));
            }
            name = value;
        }
    }

    public double Budget
    {
        get => budget;
        private set
        {
            if (budget < 0)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.InvalidBudgetAmount));
            }
        }
    }

    public double MilitaryPower => Math.Round(this.CalculateMilitaryPower(), 3);

    public IReadOnlyCollection<IMilitaryUnit> Army => units.Models;
    public IReadOnlyCollection<IWeapon> Weapons => weapons.Models;

    public void AddUnit(IMilitaryUnit unit)
    {
        units.AddItem(unit);
    }

    public void AddWeapon(IWeapon weapon)
    {
        weapons.AddItem(weapon);
    }

    public string PlanetInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Planet: {Name}");
        sb.AppendLine($"--Budget: {Budget} billion QUID");
        sb.Append($"--Forces: ");

        if (Army.Count == 0)
        {
            sb.AppendLine("No units");
        }
        else
        {
            var units = new Queue<string>();

            foreach (var item in Army)
            {
                units.Enqueue(item.GetType().Name);
            }

            sb.AppendLine(string.Join(", ", units));
        }

        sb.Append($"--Combat equipment: ");

        if (Weapons.Count == 0)
        {
            sb.AppendLine("No weapons");
        }
        else
        {
            var equipment = new Queue<string>();

            foreach (var item in Weapons)
            {
                equipment.Enqueue(item.GetType().Name);
            }

            sb.AppendLine(string.Join(", ", equipment));
        }
        sb.AppendLine($"--Military Power: {MilitaryPower}");

        return sb.ToString().Trim();
    }

    public void Profit(double amount)
    {
        Budget += amount;
    }

    public void Spend(double amount)
    {
        if (Budget < amount)
        {
            throw new ArgumentException(string.Format(string.Format(ExceptionMessages.UnsufficientBudget)));
        }
        Budget -= amount;
    }

    public void TrainArmy()
    {
        foreach (var unit in Army)
        {
            unit.IncreaseEndurance();
        }
    }

    private double CalculateMilitaryPower()
    {
        double result = units.Models.Sum(x => x.EnduranceLevel) + weapons.Models.Sum(x => x.DestructionLevel);

        if (units.Models.Any(x => x.GetType().Name == nameof(AnonymousImpactUnit)))
        {
            result *= 1.3;
        }
        if (weapons.Models.Any(x => x.GetType().Name == nameof(NuclearWeapon)))
        {
            result *= 1.45;
        }

        return result;
    }
}
