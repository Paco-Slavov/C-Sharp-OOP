using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Utilities.Messages;
using System;
using System.Threading;

namespace PlanetWars_02.Models.MilitaryUnits.Entities;

public class MilitaryUnit : IMilitaryUnit
{
    private double cost;
    private int enduranceLevel;

    protected MilitaryUnit(double cost)
    {
        Cost = cost;
        enduranceLevel = 1;
    }
    public double Cost
    {
        get => cost;
        private set => cost = value;
    }

    public int EnduranceLevel => enduranceLevel;

    public void IncreaseEndurance()
    {
        if (enduranceLevel == 20)
        {
            throw new ArgumentException(string.Format(ExceptionMessages.EnduranceLevelExceeded));
        }
        enduranceLevel++;
    }
}
