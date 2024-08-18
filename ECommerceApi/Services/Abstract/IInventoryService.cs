namespace ECommerceApi.Services.Abstract;

public interface IInventoryService
{
    Task<int> GetStockAsync(int productId);
}