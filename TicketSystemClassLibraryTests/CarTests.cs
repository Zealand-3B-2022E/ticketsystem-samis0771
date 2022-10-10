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
        /// <summary>
        /// Creates a new obj of Car class
        /// </summary>
        Car c = new Car();

        /// <summary>
        /// Tests if the method returns double 240
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedPrice = 240;
            double ActuelPrice = c.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }
        /// <summary>
        /// Tests if the method returns string "Car"
        /// </summary>
        [TestMethod()]
        public void VehicleTypeTest()
        {
            string ExpectedVehicle = "Car";
            string ActuelVehicle = c.VehicleType();
            Assert.AreEqual(ExpectedVehicle, ActuelVehicle);
        }
        /// <summary>
        /// Tests if the property returns an ArgumentException if licenseplate exceeds 7 char
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]

        public void LicenseTest()
        {
            c.Licenseplate = "AB345678";
            Assert.ThrowsException<ArgumentException>(() => c.Licenseplate);
        }

        /// <summary>
        /// Tests if the price is reduced with 5% if the bool Brobizz is true
        /// </summary>

        [TestMethod()]
        public void PriceTestDiscountActive()
        {
            double ExpectedPrice = 228;
            bool Brobizz = c.Brobizz = true;
            double ActuelPrice = c.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }
        /// <summary>
        /// Tests if the price is NOT reduced with 5% if the bool Brobizz is false
        /// </summary>
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