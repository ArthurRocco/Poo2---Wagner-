using System;

public class Cone : FiguraGeometrica
{
    public double Raio { get; set; }
    public double Altura { get; set; }

    public Cone(double raio, double altura)
    {
        Raio = raio;
        Altura = altura;
    }

    public override double CalcularPerimetro()
    {
        double geratriz = Math.Sqrt(Raio * Raio + Altura * Altura);
        return Math.PI * Raio + Math.PI * geratriz;
    }

    public override double CalcularArea()
    {
        double geratriz = Math.Sqrt(Raio * Raio + Altura * Altura);
        return Math.PI * Raio * (Raio + geratriz);
    }

    public override double CalcularVolume()
    {
        return (1.0 / 3) * Math.PI * Math.Pow(Raio, 2) * Altura;
    }
}
