using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AttackMethodShouldDecreaseDurabilityPoints()
        {
            Dummy Dummy = new(10, 10);
            Axe axe = new(10, 10);

            axe.Attack(Dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }
        [Test]
        public void AttackMethodShouldThrowAnExceptionOfDurabilityIsZero()
        {
            Dummy dummy = new Dummy(100, 100);
            Axe axe = new Axe(10, 10);

            for (int i = 0; i < 10; i++)
            {
                axe.Attack(dummy);
            }

            Assert.Throws<InvalidOperationException>(
                () => axe.Attack(dummy),
                "Axe is broken.");
        }
    }
}