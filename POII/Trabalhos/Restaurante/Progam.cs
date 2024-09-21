class Program
{
    static void Main(string[] args)
    {
        IHamburguer hamburguer = new HamburguerSimples();
        hamburguer = new Queijo(hamburguer);
        hamburguer = new Bacon(hamburguer);

        Pedido pedido = new Pedido();
        MonitorProducao producao = new MonitorProducao();
        MonitorMontagem montagem = new MonitorMontagem();

        pedido.AddObserver(producao);
        pedido.AddObserver(montagem);

        pedido.SetStatus("Em Produção", hamburguer.GetDescricao());

        pedido.SetStatus("Pronto para Entrega", hamburguer.GetDescricao());

        Console.WriteLine($"Pedido: {hamburguer.GetDescricao()} - Total: R$ {hamburguer.GetCusto()}");
    }
}
