namespace PersonInfo;

public class Citizen : IPerson, IIdentifiable, IBirthable
{
    private string name;
    private int age;
    private string id;
    private string birthDate;

    public Citizen(string name, int age, string id, string birthdate)
    {
        Name = name;
        Age = age;
        Id = id;
        Birthdate = birthdate;
    }

    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
    public string Id { get => id; set => id = value; }
    public string Birthdate { get => birthDate; set => birthDate = value; }
}