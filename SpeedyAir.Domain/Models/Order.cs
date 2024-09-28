using System;
using System.Net.NetworkInformation;

namespace SpeedyAir.Domain.Models
{
	public class Order
	{
        public string Id { get; set; }
        public string Destination { get; set; }
        public Flight Flight { get; set; }

        public override string ToString()
        {
            string status = this.Flight != null ? $"flightNumber: {this.Flight.FlightNumber}, departure: {this.Flight.Departure}, arrival: {this.Flight.Arrival}, day: {this.Flight.Day}" : "flightNumber: not scheduled";
            return $"order: {this.Id}, {status}";
        }
    }
}

