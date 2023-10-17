using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Utilities.Messages;
using System;

namespace PlanetWars_02.Models.Weapons.Entities;

public class Weapon : IWeapon
{
    private double price;
    private int destructionLevel;

    public Weapon(double price, int destructionLevel)
    {
        this.price = price;
        this.destructionLevel = destructionLevel;
    }

    public double Price { get => price; private set => price = value; }
    public int DestructionLevel
    {
        get => destructionLevel;

        private set
        {
            if (value < 1)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.TooLowDestructionLevel));
            }

            if (value > 10)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.TooHighDestructionLevel));
            }

            destructionLevel = value;
        }
    }
}
