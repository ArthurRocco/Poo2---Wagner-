//Creator
public abstract class Transportadora
{
  //Factory Method
  public abstract ITransporte CriarTransporte();

  //Método de alto nível que utiliza o transporte criado
  public void RealizarEntrega()
  {
    ITransporte transporte = CriarTransporte();
    transporte.Entregar();
  }
}