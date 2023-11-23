using Company.FlightTickets.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.FlightTickets.BusinessLayer
{
    public class FlightCheckAvailability
    {
        public bool Check(FlightBookingEntity bookingEntity)
        {
            //this code is for simulating the availability
            Random rnd = new();
            int availability = rnd.Next(0,1);

            Console.WriteLine($"Verifying flight availability from {bookingEntity.From} to {bookingEntity.To} on {bookingEntity.Date}");
            
            return (availability == 1) ? true : false;
        }
    }
}
