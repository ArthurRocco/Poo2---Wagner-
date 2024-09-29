public class Bacon : IngredienteDecorator
{
    public Bacon(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return _hamburguer.GetDescricao() + ", Bacon";
    }

    public override double GetPreco()
    {
        return _hamburguer.GetPreco() + 2.00;
    }
}
