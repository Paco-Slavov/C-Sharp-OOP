using EDriveRent.Models.Abstract_Classes;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace EDriveRent.Repositories;

public class UserRepository : IRepository<IUser>
{
    private List<IUser> users;
    public UserRepository()
    {
        users = new List<IUser>();
    }
    public void AddModel(IUser user)
    {
        users.Add(user);
    }

    public IUser FindById(string identifier) => users.FirstOrDefault(u => u.DrivingLicenseNumber == identifier);

    public IReadOnlyCollection<IUser> GetAll() => users;

    public bool RemoveById(string identifier) => users.Remove(FindById(identifier));
    }
}
