using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models.Abstract_Classes;

public class User : IUser
{

    private string firstName;
    private string lastName;
    private double rating;
    private string drivingLicenseNumber;
    private bool isBlocked;


    public User(string firstName, string lastName, string drivingLicenseNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        DrivingLicenseNumber = drivingLicenseNumber;
        rating = 0;
        isBlocked = false;
    }
    public string FirstName
    {
        get => firstName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.FirstNameNull));
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get => firstName;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.LastNameNull));
            }
            lastName = value;
        }
    }
    public string DrivingLicenseNumber
    {
        get => drivingLicenseNumber;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.DrivingLicenseRequired));
            }
            drivingLicenseNumber = value;
        }
    }
    public double Rating => this.rating;

    public bool IsBlocked => this.isBlocked;

    public void IncreaseRating()
    {
        if (rating < 10)
        {
            rating += 0.5;
        }
    }

    public void DecreaseRating()
    {
        if (rating < 2)
        {
            rating = 0;
            isBlocked = true;
        }
        else
        {
            rating -= 2;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} Driving license: {drivingLicenseNumber} Rating: {rating}";
    }
}
