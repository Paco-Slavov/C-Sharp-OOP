using PlanetWars.Models.Weapons.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars_02.Repositories.Entities
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private List<IWeapon> weapons;
        public WeaponRepository() => weapons = new List<IWeapon>();

        public IReadOnlyCollection<IWeapon> Models => weapons;

        public void AddItem(IWeapon model) => weapons.Add(model);

        public IWeapon FindByName(string name) => weapons.FirstOrDefault(w => w.GetType().Name == name);

        public bool RemoveItem(string weaponName) => weapons.Remove(weapons.FirstOrDefault(w => w.GetType().Name == weaponName));
    }
}
