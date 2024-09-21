public class Pedido : IPedido
{
    private List<IObserver> observers = new List<IObserver>();
    private string pedidoStatus;
    private string pedidoDescricao;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void SetStatus(string status, string descricao)
    {
        this.pedidoStatus = status;
        this.pedidoDescricao = descricao;
        NotifyObservers();
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(pedidoStatus, pedidoDescricao);
        }
    }
}
