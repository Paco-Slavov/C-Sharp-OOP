using PersonsInfo;
using System;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = new();

        for (int i = 0; i < n; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));

            people.Add(person);
        }

        decimal parcentage = decimal.Parse(Console.ReadLine());
        people.ForEach(p => p.IncreaseSalary(parcentage));

        people.ForEach(p => Console.WriteLine(p.ToString()));
    }
}
