using MuOnline.Season_6.Heroes.HeroesStatistics;
using System;

namespace MuOnline.Season_6.Heroes;

public abstract class HeroesInfo : IHero, IIdentifiable, IProgress
{
    private string username;
    private int strength;
    private int agility;
    private int vitality;
    private int DarkKnightEnergy;
    private double experience;
    private int level;
    private int resets;
    private int grandresets;
    private int command;

    protected HeroesInfo(string username, int strength, int agility, int vitality, int energy, int command)
    {
        Username = username;
        Strength = strength;
        Agility = agility;
        Vitality = vitality;
        Energy = energy;
        Command = command;

        Experience = 0;
        Level = 0;
        Resets = 0;
        GrandResets = 0;
    }

    public string Username { get => username; private set => username = value; }
    public int Strength { get => strength; private set => strength = value; }
    public int Agility { get => agility; private set => agility = value; }
    public int Vitality { get => vitality; private set => vitality = value; }
    public int Energy { get => DarkKnightEnergy; private set => DarkKnightEnergy = value; }
    public int Command { get => command; private set => command = value; }
    public double Experience { get => experience; private set => experience = value; }
    public int Level { get => level; private set => level = value; }
    public int Resets { get => resets; private set => resets = value; }
    public int GrandResets { get => grandresets; private set => grandresets = value; }
}
