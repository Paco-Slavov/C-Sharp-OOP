using MuOnline.Core.Factories.Interface;
using MuOnline.Season_6.Monsters.MonstersStatistics;
using System.Reflection;
using System;
using System.Linq;
using MuOnline.Season_6.Validation;

namespace MuOnline.Core.Factories;

public class MonsterFactory : IMonsterFactory
{
    public IMonster Create(string monsterTypeName)
    {
        string monsterTypeToCheck = monsterTypeName.ToLower();

        var monsterType = Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(x => x.Name.ToLower() == monsterTypeToCheck);

        Validator.ThrowAnExceptionIfObjectIsNull(monsterType, nameof(IMonster));

        var monster = Activator.CreateInstance(monsterType) as IMonster;

        return monster;
    }
}
