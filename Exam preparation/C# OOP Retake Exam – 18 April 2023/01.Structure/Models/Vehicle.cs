using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models
{
    public class Vehicle : IVehicle
    {
        private string brand;
        private string model;
        private double maxMileage;
        private string licensePlateNumber;
        private int batteryLevel;
        private bool isDamaged;

        public Vehicle(string brand, string model, double maxMileage, string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            this.maxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            batteryLevel = 100;
            isDamaged = false;
        }
        public string Brand
        {
            get => brand;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.BrandNull));
                }
                brand = value;
            }
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ModelNull));
                }
                model = value;
            }
        }
        public double MaxMileage => maxMileage;

        public string LicensePlateNumber
        {
            get => licensePlateNumber;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.LicenceNumberRequired));
                }
                licensePlateNumber = value;
            }
        }

        public int BatteryLevel => batteryLevel;

        public bool IsDamaged => isDamaged;

        public void ChangeStatus()
        {
            if (!IsDamaged)
            {
                isDamaged = true;
            }
            else
            {
                isDamaged = false;
            }
        }

        public void Drive(double mileage)
        {
            double percentage = Math.Round((mileage / maxMileage) * 100);
            batteryLevel -= (int)percentage;

            if (GetType().Name == nameof(CargoVan))
            {
                batteryLevel -= 5;
            }
        }

        public void Recharge()
        {
            batteryLevel = 100;
        }

        public override string ToString()
        {
            string vehicleStatus;

            if (isDamaged)
            {
                vehicleStatus = "damaged";
            }
            else
            {
                vehicleStatus = "OK";
            }

            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: {vehicleStatus}";
        }
    }
}
