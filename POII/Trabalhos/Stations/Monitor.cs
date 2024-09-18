using System;

public class Monitor : IObserver
{
    public string Name { get; set; }

    public Monitor(string name)
    {
        Name = name;
    }

    public void Update(float temperature, string uf)
    {
        Console.WriteLine($"Monitor {Name}: Temperatura atual da estação em {uf} é {temperature}°C");
    }
}
