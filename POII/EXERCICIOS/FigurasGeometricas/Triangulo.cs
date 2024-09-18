public class Triangulo : FiguraGeometrica
{
    public double Lado1 { get; set; }
    public double Lado2 { get; set; }
    public double Lado3 { get; set; }
    public double Base { get; set; }
    public double Altura { get; set; }

    public Triangulo(double lado1, double lado2, double lado3, double baseTriangulo, double altura)
    {
        Lado1 = lado1;
        Lado2 = lado2;
        Lado3 = lado3;
        Base = baseTriangulo;
        Altura = altura;
    }

    public override double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3;
    }

    public override double CalcularArea()
    {
        return (Base * Altura) / 2;
    }

    public override double CalcularVolume()
    {
        return 0.0;
    }
}
