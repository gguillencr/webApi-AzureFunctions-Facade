using Company.FlightTickets.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.FlightTickets.BusinessLayer
{
    public class ManageFlightFacade
    {
        private readonly FlightCheckAvailability flightsAvailabilty;
        private readonly FlightReservation flightReservation;
        private readonly FlightEmitTicket flightTickets;
        private readonly FlightCancellation flightCancellation;

        public ManageFlightFacade()
        {
            flightsAvailabilty = new();
            flightReservation = new();
            flightTickets = new();
            flightCancellation = new();
        }

        public bool BookFlight(FlightBookingEntity bookingEntity)
        {
            if (flightsAvailabilty.Check(bookingEntity))
            {
                flightReservation.Book(bookingEntity);
                flightTickets.Emit(bookingEntity);
                return true;
            }
            else
            {
                Console.WriteLine("Sorry, there isn't availability for the selected flight.");
                return false;
            }
        }

        public bool CancelFlight(string reservationId)
        {
            flightCancellation.Cancel(reservationId);
            return true;
        }
    }

}
