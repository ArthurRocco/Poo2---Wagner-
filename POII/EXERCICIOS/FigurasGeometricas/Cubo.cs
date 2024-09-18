public class Cubo : FiguraGeometrica
{
    public double Lado { get; set; }

    public Cubo(double lado)
    {
        Lado = lado;
    }

    public override double CalcularPerimetro()
    {
        return 12 * Lado;
    }

    public override double CalcularArea()
    {
        return 6 * (Lado * Lado);
    }

    public override double CalcularVolume()
    {
        return Lado * Lado * Lado;
    }
}
