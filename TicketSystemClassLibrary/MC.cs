using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystemClassLibrary
{
    /// <summary>
    /// MC class inheritance from Vehicle class
    /// </summary>
    public class MC:Vehicle
    {
       
        /// <summary>
        /// Price method from Vehicle class that is overriden to return 125
        /// It also checks if brobizz is true 
        /// </summary>
        /// <returns>125 or 118.75</returns>
        public override double Price()
        { if (Brobizz==true)
             return 125 - (125*0.05);

            else 

            return 125; }
        /// <summary>
        /// VehicleType method from Vehicle class that is overidden to return "MC"
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        { return "MC"; }
    }
}
