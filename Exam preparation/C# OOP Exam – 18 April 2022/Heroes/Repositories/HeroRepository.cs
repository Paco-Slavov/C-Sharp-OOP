using Heroes.Models.Contracts;
using Heroes.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Repositories
{
    public class HeroRepository : IRepository<IHero>
    {
        private ICollection<IHero> heroes;

        public HeroRepository()
        {
            heroes = new List<IHero>();
        }

        public IReadOnlyCollection<IHero> Models => heroes.ToList().AsReadOnly();

        public void Add(IHero model) => heroes.Add(model);

        public IHero FindByName(string name) => heroes.FirstOrDefault(h => h.Name == name);

        public bool Remove(IHero model)
        {
            IHero hero = FindByName(model.Name);
            return heroes.Remove(hero);
        }
    }
}
