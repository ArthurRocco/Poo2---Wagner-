public class Retangulo : FiguraGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
    
    public override double CalcularPerimetro()
    {
        return 2 * (Largura + Altura);
    }

    public override double CalcularArea()
    {
        return Largura * Altura;
    }
}
