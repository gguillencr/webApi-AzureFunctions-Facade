using Company.FlightTickets.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.FlightTickets.BusinessLayer
{
    public class FlightReservation
    {
        public void Book(FlightBookingEntity bookingEntity)
        {
            Console.WriteLine($"Booking flight from {bookingEntity.From} to {bookingEntity.To} on {bookingEntity.Date}");
        }
    }
}
