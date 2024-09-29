public interface ISubject
{
    void AdicionarObserver(IObserver observer);
    void RemoverObserver(IObserver observer);
    void NotificarObservers();
}
