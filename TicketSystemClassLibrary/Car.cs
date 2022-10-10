using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// Car class inheritance from Vehicle class
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Price method from Vehicle class that is overriden to return 240
        /// It also checks if brobizz is true 
        /// </summary>
        /// <returns>240 or 228</returns>
        public override double Price()
        {
            if (Brobizz == true)
                return 240 - (240 * 0.05);

            else

                return 240;
        }

        /// <summary>
        /// VehicleType method from Vehicle class that is overidden to return "Car"
        /// </summary>
        /// <returns>"Car"</returns>
        public override string VehicleType()
        { return "Car";  }
    }
}
