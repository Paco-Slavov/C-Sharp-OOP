using Farm;

public class StartUp
{
    static void Main()
    {
        Animal animal = new();
        animal.Eat();

        Dog dog = new();
        dog.Eat();
        dog.Bark();
    }
}