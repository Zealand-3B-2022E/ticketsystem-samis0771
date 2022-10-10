using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketSystemClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        Car c = new Car();

        [TestMethod()]
        public void VehicleTypeTest()
        {
            double ExpectedPrice = 240;
            double ActuelPrice = c.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        [TestMethod()]
        public void PriceTest()
        {
            string ExpectedVehicle = "Car";
            string ActuelVehicle = c.VehicleType();
            Assert.AreEqual(ExpectedVehicle, ActuelVehicle);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]

        public void LicenseTest()
        {
            c.Licenseplate = "AB345678";
            Assert.ThrowsException<ArgumentException>(() => c.Licenseplate);
        }

        [TestMethod()]
        public void PriceTestDiscountActive()
        {
            double ExpectedPrice = 228;
            bool Brobizz = c.Brobizz = true;
            double ActuelPrice = c.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        [TestMethod()]
        public void PriceTestDiscountNotActive()
        {
            double ExpectedPrice = 240;
            bool Brobizz = c.Brobizz = false;
            double ActuelPrice = c.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }
    }
}