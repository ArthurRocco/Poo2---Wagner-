public class LeiteDecorator : CafeDecorator
{
  public LeiteDecorator(ICafe cafe): base(cafe) {}

  public override string Descricao()
  {
    return base.Descricao() + " + Leite";
  }
  public override double Custo()
  {
    return base.Custo() + 1.0;
  }
}