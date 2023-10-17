using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Repositories
{
    public class WeaponRepository : IRepository<IWeapon>
    {
        private ICollection<IWeapon> weapons;
        public WeaponRepository()
        {
            weapons = new List<IWeapon>();
        }
        public IReadOnlyCollection<IWeapon> Models => weapons.ToList().AsReadOnly();

        public void Add(IWeapon model) => weapons.Add(model);

        public IWeapon FindByName(string name) => weapons.FirstOrDefault(x => x.Name == name);

        public bool Remove(IWeapon model)
        {
            IWeapon weapon = FindByName(model.Name);
            return weapons.Remove(weapon);
        }
    }
}
