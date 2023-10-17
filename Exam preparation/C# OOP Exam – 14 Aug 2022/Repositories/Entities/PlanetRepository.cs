using PlanetWars.Models.Planets.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars_02.Repositories.Entities;

public class PlanetRepository : IRepository<IPlanet>
{
    private List<IPlanet> planets;
    public PlanetRepository() => planets = new List<IPlanet>();

    public IReadOnlyCollection<IPlanet> Models => planets;

    public void AddItem(IPlanet model) => planets.Add(model);

    public IPlanet FindByName(string name) => planets.FirstOrDefault(w => w.GetType().Name == name);

    public bool RemoveItem(string weaponName) => planets.Remove(this.planets.FirstOrDefault(w => w.GetType().Name == weaponName));
}
