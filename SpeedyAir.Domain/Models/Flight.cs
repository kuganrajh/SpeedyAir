using System;
namespace SpeedyAir.Domain.Models
{
	public class Flight
	{
        public int FlightNumber { get; private set; }
        public string Departure { get; private set; }
        public string Arrival { get; private set; }
        public int Day { get; private set; }
        public List<Order> Orders { get; private set; }

        public Flight(int flightNumber, string departure, string arrival, int day)
        {
            FlightNumber = flightNumber;
            Departure = departure;
            Arrival = arrival;
            Day = day;
            Orders = new List<Order>();
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public override string ToString()
        {
            return $"Flight: {this.FlightNumber}, departure: {this.Departure}, arrival: {this.Arrival}, day: {this.Day}";
            
        }
    }
}

