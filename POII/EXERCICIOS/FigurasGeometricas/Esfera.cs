using System;

public class Esfera : FiguraGeometrica
{
    public double Raio { get; set; }

    public Esfera(double raio)
    {
        Raio = raio;
    }

    public override double CalcularPerimetro()
    {
        return 0; 
    }

    public override double CalcularArea()
    {
        return 4 * Math.PI * Raio * Raio;
    }

    public override double CalcularVolume()
    {
        return (4.0 / 3) * Math.PI * Math.Pow(Raio, 3);
    }
}
