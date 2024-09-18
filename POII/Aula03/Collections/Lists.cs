using System;
using System.Collections.Generic;

class Lists{
  public static void Main(string[] args){
    /*
      Collections:
        - Lists(List<T>): Ordenadas, indexadas, mutaveis e permite duplicatas
    */
    List<string> fruits = new List<string>{"Apple", "Banana", "Orange", "Lemon" };
    
    fruits.Add("pineapple");

    fruits.AddRange(new string[]{"Grape", "Watermelon"});
    
    fruits.Remove("Orange");

    Console.WriteLine(fruits[2]);

    fruits.Insert(2, "Strawberry");

    Console.WriteLine(fruits[2]);
    Console.WriteLine(fruits[2]);

    Console.WriteLine("##Imprimindo com FOR##");
    for (int i = 0; i < fruits.Count; i++){
      Console.WriteLine(i + " - " + fruits[i]);
    }

    fruits.Sort();

    foreach (string fruit in fruits){
      Console.WriteLine(fruit);
    }
    Console.WriteLine("Tamanho atual: " + fruits.Count);
    fruits.Clear();
    Console.WriteLine("Tamanho atual: " + fruits.Count);
  }
}