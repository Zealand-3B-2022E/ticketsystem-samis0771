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
    public class MCTests
    {
        MC mc = new MC();

        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedPrice = 125;
            double ActuelPrice = mc.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        [TestMethod()]
        
        public void VehicleTest()
        {
            string ExpectedVehicle = "MC";
            string ActuelVehicle = mc.VehicleType();
            Assert.AreEqual(ExpectedVehicle,ActuelVehicle);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        
        public void LicenseTest()
        {
            mc.Licenseplate = "AB345678";
            Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate);
        }

        [TestMethod()]
        public void PriceTestDiscountActive()
        {
            double ExpectedPrice = 118.75;
            bool Brobizz = mc.Brobizz =true;
            double ActuelPrice = mc.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        [TestMethod()]
        public void PriceTestDiscountNotActive()
        {
            double ExpectedPrice = 125;
            bool Brobizz = mc.Brobizz = false;
            double ActuelPrice = mc.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }
    }
}