using System;
using System.Net.NetworkInformation;

namespace SpeedyAir.Domain.Models
{
	public class Order
	{
        public string Id { get; set; }
        public string Destination { get; set; }
        public int? FlightNumber { get; set; }

        public override string ToString()
        {
          string status= this.FlightNumber.HasValue ? $"flightNumber: {this.FlightNumber}" : "flightNumber: not scheduled";
           return $"order: {this.Id}, {status}";
        }
    }
}

