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
            Assert.AreEqual(mc.Price, mc.Price);
        }

        [TestMethod()]
        public void VehicleTest()
        {
            Assert.AreEqual(mc.VehicleType,mc.VehicleType);
        }

        [TestMethod()]
        
        public void LicenseTest()
        {
            mc.Licenseplate = "AS12345";
            Assert.ThrowsException<ArgumentException>(() => mc.Licenseplate = mc.Licenseplate);           
        }

    }
}