using System;
using SpeedyAir.Infrastructure.Services;
using SpeedyAir.Data.Repository;

namespace SpeedyAir.Business.Services
{
	public class FlightService : IFlightService
	{
        public void DisplaySchedule()
        {
            FlightRespository flightRespository = new FlightRespository();

            foreach (var flight in flightRespository.LoadFlights())
            {
                Console.WriteLine(flight);
            }
        }
    }
}

