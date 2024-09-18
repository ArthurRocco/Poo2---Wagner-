// Creator concreto para caminhao
public class TransportadoraVan : Transportadora
{
  public override ITransporte CriarTransporte()
  {
    return new Van();
  }
}