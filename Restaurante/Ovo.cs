public class Ovo : IngredienteDecorator
{
    public Ovo(IHamburguer hamburguer) : base(hamburguer) { }

    public override string GetDescricao()
    {
        return _hamburguer.GetDescricao() + ", Ovo";
    }

    public override double GetPreco()
    {
        return _hamburguer.GetPreco() + 1.00;
    }
}
