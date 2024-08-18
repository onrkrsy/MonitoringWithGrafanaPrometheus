using ECommerceApi.Models;

namespace ECommerceApi.Services.Abstract;

public interface IOrderService
{
    Task<Order> CreateOrderAsync(Order order);
    Task<Order> GetOrderAsync(int id);
}
