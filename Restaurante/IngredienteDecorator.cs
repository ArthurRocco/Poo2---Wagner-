public abstract class IngredienteDecorator : IHamburguer
{
    protected IHamburguer _hamburguer;

    public IngredienteDecorator(IHamburguer hamburguer)
    {
        _hamburguer = hamburguer;
    }

    public virtual string GetDescricao()
    {
        return _hamburguer.GetDescricao();
    }

    public virtual double GetPreco()
    {
        return _hamburguer.GetPreco();
    }
}
