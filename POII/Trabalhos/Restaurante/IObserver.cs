public interface IObserver
{
    void Update(string pedidoStatus, string pedidoDescricao);
}

public interface IPedido
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}
