using Farm;

public class StartUp
{
    static void Main()
    {
        Dog dog = new();
        dog.Eat();
        dog.Bark();

        Cat cat = new();
        cat.Eat();
        cat.Meow();
    }
}