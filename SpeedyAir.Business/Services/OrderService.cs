using System;
using SpeedyAir.Data.Repository;
using SpeedyAir.Domain.Models;
using SpeedyAir.Infrastructure;
using SpeedyAir.Infrastructure.Services;

namespace SpeedyAir.Business.Services
{
	public class OrderService:IOrderService
	{
        
        public void AssignAndDisplayOrders()
        {
            OrderRepository orderRepository = new OrderRepository();
            FlightRespository flightRespository = new FlightRespository();

            var _orders = orderRepository.LoadOrders("./coding-assigment-orders.json");
            var _flights = flightRespository.LoadFlights();

            foreach (var order in _orders)
            {
                Flight currentFlight = _flights.Find(f => f.Arrival == order.Destination && f.Orders.Count <= Constants.MAX_CAPACITY);
                if (currentFlight !=null)
                {
                    currentFlight.AddOrder(order);
                    order.Flight = currentFlight;
                }

                Console.WriteLine(order);
            }
        }
    }
}

