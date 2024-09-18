using System;

public class Program
{
  public static void Main(string[] args)
  {
    ICafe cafeSimples = new CafeSimples();

    Console.WriteLine(cafeSimples.Descricao() + " custa " + cafeSimples.Custo());

    ICafe cafeComLeite = new LeiteDecorator(cafeSimples);
    Console.WriteLine(cafeComLeite.Descricao() + " custa " + cafeComLeite.Custo());

    ICafe cafeComLeiteEChocolate = new ChocolateDecorator(cafeComLeite);
    Console.WriteLine(cafeComLeiteEChocolate.Descricao() + " custa " + cafeComLeiteEChocolate.Custo());
  }
}