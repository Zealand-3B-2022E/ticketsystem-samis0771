using TicketSystemClassLibrary;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Car car = new Car();

            Assert.AreEqual("car", car.VehicleType);
        }
    }
}