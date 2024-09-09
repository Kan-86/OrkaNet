namespace OrkaNet.Entities;
public class Trade
{
    public int Id { get; set; }
    public string TraderName { get; set; }
    public string EnergyProduct { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public DateTime TradeDate { get; set; }
}

