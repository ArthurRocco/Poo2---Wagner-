public class MonitorProducao : IObserver
{
    public void Atualizar(string mensagem)
    {
        Console.WriteLine($"[Producao] Recebido: {mensagem}");
    }
}
