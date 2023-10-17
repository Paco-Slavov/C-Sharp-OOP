using MuOnline.Season_6.Heroes;

namespace MuOnline.Season_6.Heroes;

public class Summoner : HeroesInfo
{
    private const int SummonerStrength = 21;
    private const int SummonerAgility = 21;
    private const int SummonerVitality = 18;
    private const int SummonerEnergy = 23;
    private const int SummonerCommand = 0;
    public Summoner(string username)
        : base(username, SummonerStrength, SummonerAgility, SummonerVitality, SummonerEnergy, SummonerCommand)
    {

    }
}
