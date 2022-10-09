﻿using System;
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

        public string Licenseplate
        {
            get => _licenseplate;
            set
            {
                if (value== null || value.Length>7)
                {
                    throw new ArgumentException($"Licenseplate should be 7 or less char long but is {value}");
                }
                _licenseplate = value;
            }
        }

        public DateTime Date
        {
            get => _datetime;
            set => _datetime = value;
        }

        public abstract double Price();


        public abstract string VehicleType();
    }
}
