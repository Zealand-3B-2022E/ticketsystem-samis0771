using TicketSystemClassLibrary;
namespace StoreBaeltTicketLibrary
    
{
    public class Car : Vehicle
    {
        double A = 240;
        double B = 0.05;
        double C = 0.20;
       

        private double d;

        public double D
        {
            get { return d; }
            set { d = value; }
        }


        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday & Brobizz == true)

            {
                return 192 - 192 * 0.05;
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