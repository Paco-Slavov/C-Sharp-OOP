using BirthDayCelebrations.Models.Interfaces;

namespace BirthDayCelebrations.Models;

public class Robot : IEnter
{
    public Robot(string model, string id)
    {
        Model = model;
        Id = id;
    }

    public string Model { get; private set; }
    public string Id { get; private set; }
}
