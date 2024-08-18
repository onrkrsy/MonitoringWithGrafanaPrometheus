using ECommerceApi.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<int>> GetStock(int productId)
        {
            var stock = await _inventoryService.GetStockAsync(productId);
            return Ok(stock);
        }
    }
}
