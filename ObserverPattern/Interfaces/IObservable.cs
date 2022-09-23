namespace FirstWorkshop.Interfaces;

public interface IObservable
{
    void Subscribe(IObserver observer);
    void Notify();
}
