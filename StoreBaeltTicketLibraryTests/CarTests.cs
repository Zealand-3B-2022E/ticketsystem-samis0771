using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        /// <summary>
        /// New obj of Car class from StorBaeltTicketLibrary solution
        /// </summary>
        StoreBaeltTicketLibrary.Car car =new Car();

        /// <summary>
        /// Test price method if it detects whether it is sunday or satuarday from the date and prints out the correct price. 
        /// </summary>
        [TestMethod()]
        public void PriceTest()
        {
            double ExpectedPrice = 182.4;
            car.Date=new DateTime(2022,10,9);
            bool Brobizz = car.Brobizz = true;
            double ActuelPrice = car.Price();
            Assert.AreEqual(ExpectedPrice, ActuelPrice);
        }
    }
}