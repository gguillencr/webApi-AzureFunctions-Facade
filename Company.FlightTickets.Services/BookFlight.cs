using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Company.FlightTickets.EntityLayer;
using Company.FlightTickets.BusinessLayer;

namespace Company.FlightTickets.Services
{
    public static class BookFlight
    {
        [FunctionName("BookFlight")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "api/flights/book")] HttpRequest req,
            ILogger log)
        {

            log.LogInformation("api/flights/book processed a request.");

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            FlightBookingEntity flightBooking = JsonConvert.DeserializeObject<FlightBookingEntity>(requestBody);

            ManageFlightFacade manageFlightFacade = new();
            bool result = manageFlightFacade.BookFlight(flightBooking);

            return new OkObjectResult(new { ReservationStatus = result });
        }
    }
}
