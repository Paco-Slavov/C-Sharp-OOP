using Farm;

public class StartUp
{
    static void Main()
    {
        Animal animal = new();
        animal.Eat();

        Puppy puppy = new();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
    }
}