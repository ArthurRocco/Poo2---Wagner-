using System;

public class Circulo : FiguraGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }

    public override double CalcularVolume()
    {

        throw new NotImplementedException("Para calcular o volume, é necessário fornecer uma altura.");
    }
}
