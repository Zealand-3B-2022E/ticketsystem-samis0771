using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public abstract class Vehicle
    {
        public string _licenseplate;

        private DateTime _datetime;

        private bool _brobizz;

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

        public DateTime Date
        {
            get => _datetime;
            set => _datetime = value;
        }

        public bool Brobizz
        {
            get => _brobizz;
            set => _brobizz = value;
        }

        public abstract double Price();


        public abstract string VehicleType();


               
    }
}
