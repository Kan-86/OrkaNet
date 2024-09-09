using Microsoft.AspNetCore.Mvc;
using OrkaNet.Entities;

namespace OrkaNet.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TradesController : ControllerBase
{
    private static List<Trade> trades = new List<Trade>();

    [HttpGet]
    public ActionResult<IEnumerable<Trade>> GetAllTrades()
    {
        return Ok(trades);
    }

    [HttpPost]
    public ActionResult AddTrade([FromBody] Trade trade)
    {
        trades.Add(trade);
        return Ok();
    }
}
