using Microsoft.VisualBasic;
using MuOnline.Season_6.Monsters.MonstersStatistics;
using System.ComponentModel.DataAnnotations;
using System.Windows.Markup;

namespace MuOnline.Season_6.Monsters;
public class Monster : IMonster
{
    private int damage;
    private int health;
    private int defense;

    public Monster (int Damage, int Health, int Defense)
    {
        Damage = damage;
        Health = health;
        Defense = defense;
    }

    public int Damage
    {
        get => damage;
        private set
        {
            Validator.ThrowExceptionIfIntIsLessThanZero(nameof(damage), value);

            damage = value;
        }
    }
    public int Health { get => health; private set => health = value; }

    public int Defense { get => defense; private set => defense = value; }

    public bool IsAlive => Health > 0;
}
