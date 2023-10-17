using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo;

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
            Person person = new(personInfo[0], personInfo[1], age);

            people.Add(person);
        }
        foreach (var item in people.OrderBy(x => x.FirstName).ThenBy(x => x.Age))
        {
            Console.WriteLine(item.ToString());
        }

    }
}