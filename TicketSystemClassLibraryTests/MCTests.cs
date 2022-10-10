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

    }
}