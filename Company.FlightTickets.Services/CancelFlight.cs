using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Company.FlightTickets.BusinessLayer;
using Company.FlightTickets.EntityLayer;

namespace Company.FlightTickets.Services
{
    public static class CancelFlight
    {
        [FunctionName("CancelFlight")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "api/flights/cancel/{reservationId}")] HttpRequest req,string reservationId,
            ILogger log)
        {

            log.LogInformation("api/flights/cancel processed a request.");

            ManageFlightFacade manageFlightFacade = new();
            bool result = manageFlightFacade.CancelFlight(reservationId);

            return new OkObjectResult(new { ReservationStatus = result });
        }
    }
}
