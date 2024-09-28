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
                _orders = new List<Order>();
                string jsonString = File.ReadAllText(filePath);

                Dictionary<string, Dictionary<string, string>> orders = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(jsonString);

                foreach (var item in orders)
                {
                    Order order = new Order();
                    order.Id = item.Key; 
                    order.Destination = item.Value["destination"];
                    _orders.Add(order);
                }
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

