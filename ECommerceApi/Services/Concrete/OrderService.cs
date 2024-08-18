using ECommerceApi.Models;
using ECommerceApi.Services.Abstract;
using Prometheus;
using System.Diagnostics.Metrics;

namespace ECommerceApi.Services.Concrete;
public class OrderService : IOrderService
{
    private static readonly Counter OrdersCreated = Metrics
        .CreateCounter("orders_created_total", "Total number of orders created");

    private static readonly Gauge ActiveOrders = Metrics
        .CreateGauge("active_orders", "Number of active orders");

    private static readonly Histogram OrderProcessingTime = Metrics
        .CreateHistogram("order_processing_seconds", "Time taken to process orders");

    private readonly List<Order> _orders = new List<Order>();

    public async Task<Order> CreateOrderAsync(Order order)
    {
        using (OrderProcessingTime.NewTimer())
        {
            // Simulating some processing time
            await Task.Delay(Random.Shared.Next(100, 1000));

            order.Id = _orders.Count + 1;
            order.Status = "Processing";
            _orders.Add(order);

            OrdersCreated.Inc();
            ActiveOrders.Inc();

            return order;
        }
    }

    public async Task<Order> GetOrderAsync(int id)
    {
        // Simulating database access delay
        await Task.Delay(Random.Shared.Next(50, 200));

        return _orders.FirstOrDefault(o => o.Id == id);
    }
}
