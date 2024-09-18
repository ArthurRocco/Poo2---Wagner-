using System;

public class Van : ITransporte
{
  public void Entregar()
  {
    Console.WriteLine("Entrega feita de van.");   
  }
}