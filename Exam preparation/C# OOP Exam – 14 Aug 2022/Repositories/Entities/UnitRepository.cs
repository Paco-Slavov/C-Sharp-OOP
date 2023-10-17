using PlanetWars.Models.MilitaryUnits.Contracts;
using PlanetWars.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace PlanetWars_02.Repositories.Entities;

public class UnitRepository : IRepository<IMilitaryUnit>
{
    private List<IMilitaryUnit> units;
    public UnitRepository() => units = new List<IMilitaryUnit>();

    public IReadOnlyCollection<IMilitaryUnit> Models => units;

    public void AddItem(IMilitaryUnit model) => units.Add(model);

    public IMilitaryUnit FindByName(string name) => units.FirstOrDefault(w => w.GetType().Name == name);

    public bool RemoveItem(string weaponName) => units.Remove(units.FirstOrDefault(w => w.GetType().Name == weaponName));
}