namespace MuOnline.Season_6.Heroes;

public class Rage_Fighter : HeroesInfo
{
    private const int RageFighterStrength = 32;
    private const int RageFighterAgility = 27;
    private const int RageFighterVitality = 25;
    private const int RageFighterEnergy = 20;
    private const int RageFighterCommand = 0;
    public Rage_Fighter(string username)
        : base(username, RageFighterStrength, RageFighterAgility, RageFighterVitality, RageFighterEnergy, RageFighterCommand)
    {
    }
}
