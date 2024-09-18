public abstract class CafeDecorator : ICafe
{
  protected ICafe _cafeDecorado;

  public CafeDecorator(ICafe cafe)
  {
    _cafeDecorado = cafe;
  }

  public virtual string Descricao()
  {
    return _cafeDecorado.Descricao();
  }

  public virtual double Custo()
  {
    return _cafeDecorado.Custo();
  }
}