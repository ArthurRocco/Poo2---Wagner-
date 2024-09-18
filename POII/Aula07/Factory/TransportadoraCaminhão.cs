// Creator concreto para caminhao
public class TransportadoraCaminhao : Transportadora
{
  public override ITransporte CriarTransporte()
  {
    return new Caminhao();
  }
}