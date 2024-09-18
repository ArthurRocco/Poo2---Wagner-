public class ChocolateDecorator : CafeDecorator
{
  public ChocolateDecorator(ICafe cafe): base(cafe) {}

  public override string Descricao()
  {
    return base.Descricao() + " + Chocolate";
  }
  public override double Custo()
  {
    return base.Custo() + 2.0;
  }
}