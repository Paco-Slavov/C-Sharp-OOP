namespace MuOnline.Season_6.Heroes;
public class DarkLord : HeroesInfo
{
    private const int DarkLordStrength = 26;
    private const int DarkLordAgility = 20;
    private const int DarkLordVitality = 20;
    private const int DarkLordEnergy = 15;
    private const int DarkLordCommand = 25;
    public DarkLord(string username)
        : base(username, DarkLordStrength, DarkLordAgility, DarkLordVitality, DarkLordEnergy, DarkLordCommand)
    {

    }

}