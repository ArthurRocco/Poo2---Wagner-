public class MonitorProducao : IObserver
{
    public void Update(string pedidoStatus, string pedidoDescricao)
    {
        Console.WriteLine($"Monitor Produção: Pedido {pedidoStatus}. Ingredientes: {pedidoDescricao}");
    }
}


