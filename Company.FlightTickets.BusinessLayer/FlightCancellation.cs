using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.FlightTickets.BusinessLayer
{
    public class FlightCancellation
    {
        public void Cancel(string reservation)
        {
            Console.WriteLine($"Cancelling reservation id {reservation}");
        }
    }
}
