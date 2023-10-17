using PersonsInfo;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new();

        for (int i = 0; i < n; i++)
        {
            string[] personInfo = Console.ReadLine().Split();

            int age = int.Parse(personInfo[2]);
            decimal salary = decimal.Parse(personInfo[3]);

            Person person = new(personInfo[0], personInfo[1], age , salary);

            people.Add(person);
        }
        decimal percentage = decimal.Parse(Console.ReadLine());

        foreach (Person person in people)
        {
            person.IncreaseSalary(percentage);
            Console.WriteLine(person.ToString());
        }
    }
}