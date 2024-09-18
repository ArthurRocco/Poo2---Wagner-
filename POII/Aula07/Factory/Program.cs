public class Program
{
  public static void Main(string[] args)
  {
    Transportadora tc = new TransportadoraCaminhao();
    tc.RealizarEntrega();

    Transportadora tv = new TransportadoraVan();
    tv.RealizarEntrega();

    Transportadora tb = new TransportadoraBicicleta();
    tb.RealizarEntrega();
  }
}