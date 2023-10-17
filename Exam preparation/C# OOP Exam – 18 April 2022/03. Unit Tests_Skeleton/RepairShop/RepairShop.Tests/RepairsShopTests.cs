using NUnit.Framework;

namespace RepairShop.Tests
{
    public class Tests
    {
        public class RepairsShopTests
        {
            Car car;
            Garage garage;

            [SetUp]
            public void SetUp()
            {
                car = new Car("Audi", 2);
                garage = new Garage("Service", 2);
            }

            [TearDown]
            public void TearDown()
            {
                car = null;
                garage = null;
            }

            [Test]
            public void ConstructorTest()
            {
                string actualName = garage.Name;
                string expected = "Service";
                Assert.AreEqual(expected, actualName);

                int actualMechanicsAvailable = garage.MechanicsAvailable;
                int expectedMechanicsAvailable = 3;
                Assert.AreEqual(expectedMechanicsAvailable, actualMechanicsAvailable);

                int cars = garage.CarsInGarage;
                Assert.AreEqual(cars, 0);
            }
            [TestCase(null)]
            [TestCase("")]
            public void NameValidationTest(string name)
            {
                Assert.That(() => garage = new Garage(name, 3), Throws.ArgumentNullException);
            }

            [TestCase(0)]
            [TestCase(-1)]
            public void MechanicsCountEceptionTest(int count)
            {
                Assert.That(() => garage = new Garage("name", count), Throws.ArgumentException.With.Message.EqualTo("At least one mechanic must work in the garage."));
            }

            [Test]
            public void AddCarMethodExceptionTest()
            {
                garage.AddCar(car);
                garage.AddCar(car);
                garage.AddCar(car);

                Assert.That(() => garage.AddCar(car), Throws.InvalidOperationException);
            }

            [Test]
            public void AddCarMethodTest()
            {
                garage.AddCar(car);
                Assert.AreEqual(garage.CarsInGarage, 1);
            }
            [Test]
            public void CarFixMethodExceptionTest()
            {
                Assert.That(() => garage.FixCar("Audi"), Throws.InvalidOperationException);
            }

            [Test]
            public void CarFixMethodTest()
            {
                garage.AddCar(car);
                garage.FixCar("Toyota");

                Assert.AreEqual(car.NumberOfIssues, 0);
            }
            [Test]
            public void RemoveFixedCarException()
            {
                Assert.That(() => garage.RemoveFixedCar(), Throws.InvalidOperationException);
            }
            [Test]
            public void RemoveFixedCarTest()
            {
                garage.AddCar(car);
                garage.FixCar("Toyota");

                int actual = garage.RemoveFixedCar();

                Assert.AreEqual(actual, 1);
            }
            [Test]
            public void ReportMethodTest()
            {
                garage.AddCar(car);
                garage.AddCar(new Car("Mazda", 3));

                string actual = garage.Report();
                string expected = "There are 2 which are not fixed: Audi, Mazda.";
                Assert.AreEqual(expected, actual);
            }
        }
    }
}