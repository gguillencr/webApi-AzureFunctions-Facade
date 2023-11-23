using Company.FlightTickets.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.FlightTickets.BusinessLayer
{
    public class FlightEmitTicket
    {
        public void Emit(FlightBookingEntity bookingEntity)
        {
            Console.WriteLine($"Emitting ticket to {bookingEntity.Passenger} from {bookingEntity.From} to {bookingEntity.To} on {bookingEntity.Date}");
        }
    }
}
