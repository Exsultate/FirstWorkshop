using FirstWorkshop.Interfaces;

namespace FirstWorkshop.Classes;

public class Stock : IObservable
{
    private List<IObserver> _observers;

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            _price = value;
            Notify();
        }
    }

    public string Name { get; set; }

    public Stock(string name, double price)
    {
        _observers = new List<IObserver>();

        Price = price;
        Name = name;
    }

    public void Subscribe(IObserver observer) => _observers.Add(observer);
    public void Notify() => _observers.ForEach(observer => observer.Update(this));
}
