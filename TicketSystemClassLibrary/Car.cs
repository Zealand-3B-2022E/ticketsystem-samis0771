using System.Text.RegularExpressions;

namespace TicketSystemClassLibrary
{
    public class Car
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
		/// <returns>240</returns>
		public double Price()
		{ return 240; }

        /// <summary>
        /// VehicleType methoed that returns a string
        /// </summary>
        /// <returns>Car</returns>
        public string VehicleType()
		{ return "Car"; }

	}
}