namespace FirstWorkshop.Classes;

public class TradeMarket
{
    public List<Stock> Stocks;

    public TradeMarket()
    {
        Stocks = new List<Stock>()
        {
                new Stock("Tesla", 125.0),
                new Stock("Memes Inc.", 58.0),
                new Stock("I Nuclear U", 587.0)
        };
    }

    public void UpdateRandomStockPrice(double newPrice)
    {
        var random = new Random();
        var index = random.Next(Stocks.Count);
        var stock = Stocks[index];

        stock.Price = newPrice;
    }
}