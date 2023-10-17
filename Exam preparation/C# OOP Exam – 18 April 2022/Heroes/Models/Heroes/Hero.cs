using Heroes.Models.Contracts;
using Heroes.Utilities.Messages;
using System;
using System.Text;

namespace Heroes.Models.Heroes
{
    public class Hero : IHero
    {
        private string name;
        private int health;
        private int armour;
        private IWeapon weapon;
        public Hero(string name, int health, int armour)
        {
            Name = name;
            Health = health;
            Armour = armour;
        }

        public string Name
        {
            get { return name; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.HeroNameNull));
                }
                name = value;
            }
        }

        public int Health
        {
            get { return health; }

            private set
            {
                if (health < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.HeroHealthBelowZero));
                }
                health = value;
            }
        }

        public int Armour
        {
            get { return armour; }

            private set
            {
                if (armour < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.HeroArmourBelowZero));
                }
                armour = value;
            }
        }

        public IWeapon Weapon
        {
            get { return weapon; }

            private set
            {
                if (weapon == null)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.WeaponNull));
                }
                weapon = value;
            }
        }

        public bool IsAlive => Health > 0;

        public void AddWeapon(IWeapon weapon)
        {
            if (Weapon == null)
            {
                this.weapon = weapon;
            }
        }

        public void TakeDamage(int points)
        {
            if (Armour <= points)
            {
                points -= armour;
                armour = 0;

                if (Health <= points)
                {
                    health = 0;
                }
                else
                {
                    health -= points;
                }
            }
            else
            {
                armour -= points;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{GetType().Name} : {Name}");
            stringBuilder.AppendLine($"--Health: {Health}");
            stringBuilder.AppendLine($"--Armour: {Armour}");
            string weapon = Weapon != null ? Weapon.Name : "Unarmed";
            stringBuilder.AppendLine($"--Weapon: {weapon}");

            return stringBuilder.ToString().TrimEnd();
        }
    }
}