using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public class MC
    {
     /// <summary>
     /// Instance field with 2 attributes
     /// </summary>
        private string _licenseplate;
        private DateTime _date;


        /// <summary>
        /// Property of licenseplate
        /// </summary>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set { _licenseplate = value; }
        }
        /// <summary>
        /// Property of date
        /// </summary>
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        /// <summary>
        /// Price metohed that returns a double
        /// </summary>
        /// <returns>125</returns>
        public double Price()
        { return 125; }

        /// <summary>
        /// Vehicle methoed that returns a string
        /// </summary>
        /// <returns>MC</returns>
        public string Vehicle()
        { return "MC"; }
    }
}
