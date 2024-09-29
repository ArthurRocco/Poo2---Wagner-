public class MonitorMontagem : IObserver
{
    public void Atualizar(string mensagem)
    {
        Console.WriteLine($"[Montagem] Recebido: {mensagem}");
    }
}
