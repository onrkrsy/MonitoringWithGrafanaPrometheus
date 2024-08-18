using ECommerceApi.Services.Abstract;
using Prometheus;

namespace ECommerceApi.Services.Concrete;

public class InventoryService : IInventoryService
{
    private static readonly Gauge StockLevel = Metrics
        .CreateGauge("stock_level", "Current stock level", new GaugeConfiguration
        {
            LabelNames = new[] { "product_id" }
        });

    private readonly Dictionary<int, int> _inventory = new Dictionary<int, int>
    {
        { 1, 100 },
        { 2, 150 },
        { 3, 200 }
    };

    public async Task<int> GetStockAsync(int productId)
    {
        // Simulating database access delay
        await Task.Delay(Random.Shared.Next(50, 200));

        if (_inventory.TryGetValue(productId, out int stock))
        {
            StockLevel.WithLabels(productId.ToString()).Set(stock);
            return stock;
        }

        return 0;
    }
}
