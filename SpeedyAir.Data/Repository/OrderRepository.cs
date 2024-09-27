using System;
using SpeedyAir.Domain.Models;
using System.Text.Json;

namespace SpeedyAir.Data.Repository
{
    public class OrderRepository
    {
        private List<Order> _orders;

        public List<Order> LoadOrders(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                var ordersDictionary = JsonSerializer.Deserialize<Dictionary<string, Order>>(jsonString);
                _orders = ordersDictionary.Select(x => new Order() { Id = x.Key, Destination = x.Value.Destination }).ToList();
            }
            catch (FileNotFoundException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _orders;
        }
    }
}

