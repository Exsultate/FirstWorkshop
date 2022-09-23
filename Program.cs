using FirstWorkshop.Classes;

var tradeMarket = new TradeMarket();
var user1 = new User("Thomas");
var user2 = new User("Sheila");

//Users subscribe to their wanted stocks
tradeMarket.Stocks.Find(stock => stock.Name == "Tesla")?.Subscribe(user1);
tradeMarket.Stocks.Find(stock => stock.Name == "Tesla")?.Subscribe(user2);

tradeMarket.Stocks.Find(stock => stock.Name == "I Nuclear U")?.Subscribe(user1);

tradeMarket.Stocks.Find(stock => stock.Name == "Memes Inc.")?.Subscribe(user2);

//Stock prices get updated
tradeMarket.UpdateRandomStockPrice(4277.2);
tradeMarket.UpdateRandomStockPrice(1244);
tradeMarket.UpdateRandomStockPrice(502);

Console.ReadKey();