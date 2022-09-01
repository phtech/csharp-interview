using FizzBuzz;
using NUnit.Framework;

namespace CsharpInterviewTests
{
    [TestFixture]
    class TestVehicle
    {

        [Test]
        public void TestMotorCycle()
        {
            IVehicle testsubject = null;
            // Create Motorcycle here

            TestAttributes(testsubject, "Green", 200, 2);
        }

        [Test]
        public void TestTruck()
        {
            IVehicle testsubject = null;
            // Create Motorcycle here

            TestAttributes(testsubject, "Orange", 95, 4);
        }

        public void TestAttributes(IVehicle vehicle, string expectedColor, int expectedSpeed, int numberOfWheels)
        {
            Assert.AreEqual(expectedColor, vehicle.Color);
            Assert.AreEqual(expectedSpeed, vehicle.GetTopSpeed());
            Assert.AreEqual(numberOfWheels, vehicle.GetNumberOfWheels());
        }
    }
}
