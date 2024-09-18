using System;

public class Cilindro : FiguraGeometrica
{
    public double Raio { get; set; }
    public double Altura { get; set; }

    public Cilindro(double raio, double altura)
    {
        Raio = raio;
        Altura = altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public override double CalcularArea()
    {
        return 2 * Math.PI * Raio * (Raio + Altura);
    }

    public override double CalcularVolume()
    {
        return Math.PI * Math.Pow(Raio, 2) * Altura;
    }
}
