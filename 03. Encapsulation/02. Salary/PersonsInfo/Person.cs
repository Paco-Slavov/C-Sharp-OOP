namespace PersonsInfo;

public class Person
{
    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }
    public string FirstName { get; }
    public string LastName { get; }
    public int Age { get;}
    public decimal Salary { get; set; }
    public void IncreaseSalary (decimal percentage)
    {
        if (this.Age > 30)
        {
            this.Salary += Salary * percentage / 100;
        }
        if (this.Age < 30)
        {
            this.Salary += Salary * percentage / 200;
        }
    }
    
    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
    }
}