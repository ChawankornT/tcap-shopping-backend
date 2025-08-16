using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ThanachartApi.Database;
using ThanachartApi.Models;

namespace ThanachartApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public StockController(DatabaseContext context)
        {
            _context = context;
        }

        [HttpGet("GetStocks")]
        public async Task<IActionResult> GetStocks()
        {
            var stocks = await _context.Stock.ToListAsync();
            return Ok(stocks);
        }

        [HttpPost("DecrementStock")]
        public async Task<IActionResult> DecrementStock([FromBody] Stock item)
        {
            var stock = await _context.Stock.FirstOrDefaultAsync(s => s.Id == item.Id);
            if (stock == null)
            {
                return NotFound($"Stock with code {item.ProductName} not found.");
            }
            if (stock.Quantity <= 0)
            {
                return Ok(new { message = "Out of Stock." });
            }
            if (item.Quantity <= stock.Quantity)
            {
                stock.Quantity -= item.Quantity;
            } else
            {
                return Ok(new { message = $"{stock.ProductName} is in greater quantity than stock." });
            }
            await _context.SaveChangesAsync();
            return Ok(stock);
        }

        [HttpPost("AddStock")]
        public async Task<IActionResult> AddStock([FromBody] AddStock item)
        {
            var stock = await _context.Stock.FirstOrDefaultAsync(s => s.Id == item.Id);
            if (stock == null)
            {
                return NotFound($"Stock with code {item.ProductName} not found.");
            }

            int returnQuantity = item.AddCount ?? 0;
            stock.Quantity += returnQuantity;
            await _context.SaveChangesAsync();
            return Ok(stock);
        }

    }
}
