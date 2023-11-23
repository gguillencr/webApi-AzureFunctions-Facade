using System.Text.Json.Serialization;

namespace Company.FlightTickets.EntityLayer
{
    public class FlightBookingEntity
    {
        [JsonPropertyName("passenger")]
        public string Passenger { get; set; } = String.Empty;

        [JsonPropertyName("from")]
        public string From { get; set; } = String.Empty;

        [JsonPropertyName("to")]
        public string To { get; set; } = String.Empty;

        [JsonPropertyName("date")]
        public string Date { get; set; } = String.Empty;
    }
}