using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Linq;
using SpeedyAir.Infrastructure.Services;
using SpeedyAir.Business.Services;

// Main Program Class
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // code can be modified to use DI
            IFlightService flightService = new FlightService();
            IOrderService order = new OrderService();

            flightService.DisplaySchedule();

            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 2");
            Console.WriteLine("------------------------------");

            order.AssignAndDisplayOrders();
        }
        catch (Exception ex)
        {
            // need add logs here 
            Console.WriteLine("Sorry, something wrong");
        }
        Console.ReadLine();
    }
}
