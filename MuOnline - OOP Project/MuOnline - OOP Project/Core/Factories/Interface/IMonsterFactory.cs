using MuOnline.Season_6.Monsters.MonstersStatistics;

namespace MuOnline.Core.Factories.Interface;

public interface IMonsterFactory
{
    IMonster Create(string monsterTypeName);
}
