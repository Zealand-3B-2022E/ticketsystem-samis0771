using TicketSystemClassLibrary;
namespace StoreBaeltTicketLibrary
    
{
    public class Car : Vehicle
    {

        public override double Price()
        {
            if ((Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday) & Brobizz == true)
            { return ((240 * 0.80) * 0.95); }

            else if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)

            {
                return 240 - (240 * 0.20);
            }

            else if (Brobizz == true)

            { return 240 - (240 * 0.05); }
 
            else
            { return 240; }
         }
        

        public override string VehicleType()
        {
            return "Car";
        }
    }
}