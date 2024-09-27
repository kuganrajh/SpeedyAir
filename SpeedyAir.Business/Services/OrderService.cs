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

            int flightIndex = 0;
            foreach (var order in _orders)
            {
                if (flightIndex >= _flights.Count) break;

                Flight currentFlight = _flights[flightIndex];
                if (currentFlight.Orders.Count < Constants.MAX_CAPACITY)
                {
                    currentFlight.AddOrder(order);
                    order.FlightNumber = currentFlight.FlightNumber;
                }
                else
                {
                    flightIndex++;
                    if (flightIndex < _flights.Count)
                    {
                        _flights[flightIndex].AddOrder(order);
                        order.FlightNumber = _flights[flightIndex].FlightNumber;
                    }
                }

                Console.WriteLine(order);
            }
        }
    }
}

