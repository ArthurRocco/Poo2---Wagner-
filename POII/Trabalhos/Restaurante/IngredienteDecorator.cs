public abstract class IngredienteDecorator : IHamburguer
{
    protected IHamburguer hamburguer;

    public IngredienteDecorator(IHamburguer hamburguer)
    {
        this.hamburguer = hamburguer;
    }

    public virtual string GetDescricao()
    {
        return hamburguer.GetDescricao();
    }

    public virtual double GetCusto()
    {
        return hamburguer.GetCusto();
    }
}
