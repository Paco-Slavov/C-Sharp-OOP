using CustomRandomList;

public class StartUp
{
    static void Main()
    {
        RandomList list = new();

        list.Add("1");
        list.Add("2");
        list.Add("3");

        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
        Console.WriteLine(list.RandomString());
    }
}