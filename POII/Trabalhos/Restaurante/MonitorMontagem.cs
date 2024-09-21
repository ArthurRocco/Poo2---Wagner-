public class MonitorMontagem : IObserver
{
    public void Update(string pedidoStatus, string pedidoDescricao)
    {
        Console.WriteLine($"Monitor Montagem: Pedido {pedidoStatus}. Ingredientes: {pedidoDescricao}");
    }
}