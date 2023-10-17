namespace MuOnline.Season_6.Heroes;
public class DarkWizard : HeroesInfo
{
    private const int DarkWizardStrength = 18;
    private const int DarkWizardAgility = 18;
    private const int DarkWizardVitality = 15;
    private const int DarkWizardEnergy = 30;
    private const int DarkWizardCommand = 0;
    public DarkWizard(string username) 
        : base(username, DarkWizardStrength, DarkWizardAgility, DarkWizardVitality, DarkWizardEnergy,DarkWizardCommand)
    {

    }

}
