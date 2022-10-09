using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    public class MC:Vehicle
    {
       
        
        public override double Price()
        { return 125; }

        public override string VehicleType()
        { return "MC"; }
    }
}
