using System.Collections.Generic;

public class Pedido : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _statusPedido;
    private IHamburguer _hamburguer;

    public Pedido(IHamburguer hamburguer)
    {
        _hamburguer = hamburguer;
        _statusPedido = "Pedido Criado";
    }

    public void AdicionarObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoverObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotificarObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Atualizar($"Pedido: {_hamburguer.GetDescricao()} - Status: {_statusPedido}");
        }
    }

    public void AtualizarStatus(string status)
    {
        _statusPedido = status;
        NotificarObservers();
    }

    public double GetPrecoTotal()
    {
        return _hamburguer.GetPreco();
    }
}
