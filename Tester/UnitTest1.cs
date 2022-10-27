using TicketSystemClassLibrary;

namespace Tester
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
         //Arrange
         Car c = new Car(); 
         string bil = "Car";
         //Act
        
         
         //Assert
         Assert.AreEqual(bil,c.VehicleType)
        }

    }
}