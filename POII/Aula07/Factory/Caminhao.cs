using System;

public class Caminhao : ITransporte
{
  public void Entregar()
  {
    Console.WriteLine("Entrega feita de caminhão.");   
  }
}