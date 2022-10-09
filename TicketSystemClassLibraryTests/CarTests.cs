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
            Assert.AreEqual(c.VehicleType, c.VehicleType);
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual(c.Price, c.Price);
        }
    }
}