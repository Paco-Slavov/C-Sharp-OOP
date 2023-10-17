using Heroes.Models.Contracts;
using Heroes.Utilities.Messages;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            ICollection<Hero> knights = new List<Hero>();
            ICollection<Hero> barbarians = new List<Hero>();

            foreach (var hero in players.ToList().AsReadOnly())
            {
                if (hero.GetType() == typeof(Knight))
                {
                    knights.Add((Hero)hero);
                }

                else if (hero.GetType() == typeof(Barbarian))
                {
                    barbarians.Add((Hero)hero);
                }
            }

            bool itsKnightTurn = true;

            while (knights.Any(h => h.IsAlive) && barbarians.Any(h => h.IsAlive))
            {
                if (itsKnightTurn)
                {
                    TakeFight((ICollection<IHero>)knights, (ICollection<IHero>)barbarians);
                }
                else
                {
                    TakeFight((ICollection<IHero>)barbarians, (ICollection<IHero>)knights);
                }

                itsKnightTurn = !itsKnightTurn;
            }

            if (knights.Any(h => h.IsAlive))
            {
                int knightCasualties = knights.Where(h => !h.IsAlive).Count();
                return string.Format(OutputMessages.MapFightKnightsWin, knightCasualties);
            }
            else
            {
                int barbarianCasualties = barbarians.Where(h => !h.IsAlive).Count();
                return string.Format(OutputMessages.MapFigthBarbariansWin, barbarianCasualties);
            }
        }
        private void TakeFight(ICollection<IHero> attackers, ICollection<IHero> defenders)
        {
            foreach (var attacker in attackers.Where(h => h.IsAlive))
            {
                foreach (var defender in defenders.Where(h => h.IsAlive))
                {
                    defender.TakeDamage(attacker.Weapon.DoDamage());
                }
            }
        }
    }
}
