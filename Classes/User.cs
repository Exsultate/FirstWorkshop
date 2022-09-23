using FirstWorkshop.Interfaces;

namespace FirstWorkshop.Classes;

public class User : IObserver
{
    public List<Stock> StocksSubscribedTo { get; set; }
    public string Username { get; set; }

    public User(string username)
    {
        StocksSubscribedTo = new List<Stock>();

        Username = username;
    }

    public void Update(IObservable observable)
    {
        if (observable is Stock stock)
        {
            Console.WriteLine($"Stock [{stock.Name}] you [{Username}] subscribed to has it's price updated - {stock.Price} $");
        }
    }
}
