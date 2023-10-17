namespace MuOnline.Season_6.Heroes;
public class FairyElf : HeroesInfo
{
    private const int FairyElfStrength = 22;
    private const int FairyElFAgility = 25;
    private const int FairyElfVitality = 20;
    private const int FairyElfEnergy = 15;
    private const int FairyElfCommand = 0;
    public FairyElf (string username)
        : base(username, FairyElfStrength, FairyElFAgility, FairyElfVitality, FairyElfEnergy, FairyElfCommand)
    {

    }

}