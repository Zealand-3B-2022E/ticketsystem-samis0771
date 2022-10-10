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
        /// <summary>
        /// Creates a new obj of MC class
        /// </summary>
        MC mc = new MC();

        /// <summary>
        /// Tests if the method returns double 125
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedPrice = 125;
            double ActuelPrice = mc.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        /// <summary>
        /// Tests if the method returns string "MC"
        /// </summary>
        [TestMethod()]
        
        public void VehicleTest()
        {
            string ExpectedVehicle = "MC";
            string ActuelVehicle = mc.VehicleType();
            Assert.AreEqual(ExpectedVehicle,ActuelVehicle);
        }

        /// <summary>
        /// Tests if the property returns an ArgumentException if licenseplate exceeds 7 char
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        
        public void LicenseTest()
        {
            mc.Licenseplate = "AB345678";
            Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate);
        }

        /// <summary>
        /// Tests if the price is reduced with 5% if the bool Brobizz is true
        /// </summary>
        [TestMethod()]
        public void PriceTestDiscountActive()
        {
            double ExpectedPrice = 118.75;
            bool Brobizz = mc.Brobizz =true;
            double ActuelPrice = mc.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }

        /// <summary>
        /// Tests if the price is NOT reduced with 5% if the bool Brobizz is false
        /// </summary>
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