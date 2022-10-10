using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Base class for Car class and MC class 
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Instance fields
        /// </summary>
        public string _licenseplate;
        private DateTime _datetime;
        private bool _brobizz;

        /// <summary>
        /// property Licenseplate that throws exception if string is over 7 char or is null
        /// </summary>
        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value== null || value.Length>7)
                {
                    throw new ArgumentException($"Licenseplate should be 7 or less char long");
                }
                _licenseplate = value;
            }
        }

        /// <summary>
        ///Property of Date 
        /// </summary>
        public DateTime Date
        {
            get => _datetime;
            set => _datetime = value;
        }

        /// <summary>
        /// Property of Brobizz
        /// </summary>
        public bool Brobizz
        {
            get => _brobizz;
            set => _brobizz = value;
        }

        /// <summary>
        /// Price method that is abstract
        /// </summary>
        /// <returns>125 or 240</returns>
        public abstract double Price();

        /// <summary>
        /// VehicleType method  that is abstract
        /// </summary>
        /// <returns>"Car" or "MC"</returns>
        public abstract string VehicleType();


               
    }
}
