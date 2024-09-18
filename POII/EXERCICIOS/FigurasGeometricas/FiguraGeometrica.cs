using System;

public abstract class FiguraGeometrica
{
    public abstract double CalcularPerimetro();
    public abstract double CalcularArea();
    public virtual double CalcularVolume()
    {
        return 0.0;
    }
}
