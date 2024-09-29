class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo à Lanchonete!");
        
        IHamburguer hamburguer = new HamburguerSimples();
        
        bool continuar = true;
        
        while (continuar)
        {
            Console.WriteLine($"\nSeu pedido atual: {hamburguer.GetDescricao()} - Preço: {hamburguer.GetPreco():C}");
            Console.WriteLine("Escolha um ingrediente para adicionar:");
            Console.WriteLine("1. Bacon");
            Console.WriteLine("2. Queijo");
            Console.WriteLine("3. Ovo");
            Console.WriteLine("4. Finalizar Pedido");
            
            string escolha = Console.ReadLine();
            
            switch (escolha)
            {
                case "1":
                    hamburguer = new Bacon(hamburguer);
                    break;
                case "2":
                    hamburguer = new Queijo(hamburguer);
                    break;
                case "3":
                    hamburguer = new Ovo(hamburguer);
                    break;
                case "4":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }

        Pedido pedido = new Pedido(hamburguer);

        MonitorProducao producao = new MonitorProducao();
        MonitorMontagem montagem = new MonitorMontagem();

        pedido.AdicionarObserver(producao);
        pedido.AdicionarObserver(montagem);

        pedido.AtualizarStatus("Em Produção");
        pedido.AtualizarStatus("Pronto para Entrega");

        Console.WriteLine($"\nPreço Total do Pedido: {pedido.GetPrecoTotal():C}");
        Console.WriteLine("Pedido finalizado! Obrigado pela preferência.");
    }
}
