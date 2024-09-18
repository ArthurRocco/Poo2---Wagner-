// Creator concreto para caminhao
public class TransportadoraBicicleta : Transportadora
{
  public override ITransporte CriarTransporte()
  {
    return new Bicicleta();
  }
}