using System;
using SpeedyAir.Domain.Models;

namespace SpeedyAir.Data.Repository
{
	public class FlightRespository
	{
        public List<Flight> LoadFlights()
        {
            return new List<Flight>
        {
            new Flight(1, "YUL", "YYZ", 1),
            new Flight(2, "YUL", "YYC", 1),
            new Flight(3, "YUL", "YVR", 1),
            new Flight(4, "YUL", "YYZ", 2),
            new Flight(5, "YUL", "YYC", 2),
            new Flight(6, "YUL", "YVR", 2)
        };
        }
    }
}

