using System;
using Newtonsoft.Json;

namespace Csa.Entities.Price
{
    public class Flight
    {
        [JsonProperty("flightNumber")]
        public string FlightNumber { get; set; }

        [JsonProperty("seats")]
        public string Seats { get; set; }

        [JsonProperty("rbd")]
        public string Rbd { get; set; }

        [JsonProperty("depIata")]
        public string DepIata { get; set; }

        [JsonProperty("arrIata")]
        public string ArrIata { get; set; }

        [JsonProperty("departureDateTime")]
        public DateTimeOffset DepartureDateTime { get; set; }

        [JsonProperty("arrivalDateTime")]
        public DateTimeOffset ArrivalDateTime { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("mileage")]
        public string Mileage { get; set; }

        [JsonProperty("aircraftRef")]
        public string AircraftRef { get; set; }
    }
}