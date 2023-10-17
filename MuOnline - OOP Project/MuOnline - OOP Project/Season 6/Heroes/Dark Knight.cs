namespace MuOnline.Season_6.Heroes;

public class DarkKnight : HeroesInfo
{
    private const int DarkKnightStrength = 28;
    private const int DarkKnightAgility = 20;
    private const int DarkKnightVitality = 25;
    private const int DarkKnightEnergy = 10;
    private const int DarkKnightCommand = 0;
    public DarkKnight(string username) 
        : base(username, DarkKnightStrength, DarkKnightAgility, DarkKnightVitality, DarkKnightEnergy,DarkKnightCommand)
    {

    }
}
