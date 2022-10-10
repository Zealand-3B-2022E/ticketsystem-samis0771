using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public class Car : Vehicle
    {
        public override double Price()
        {
            if (Brobizz == true)
                return 240 - (240 * 0.05);

            else

                return 240;
        }

        public override string VehicleType()
        { return "Car";  }
    }
}
