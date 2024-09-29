public class Queijo : IngredienteDecorator
{
    public Queijo(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return _hamburguer.GetDescricao() + ", Queijo";
    }

    public override double GetPreco()
    {
        return _hamburguer.GetPreco() + 1.50;
    }
}
