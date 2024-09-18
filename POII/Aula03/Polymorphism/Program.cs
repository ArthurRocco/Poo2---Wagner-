using System;
using PolymorphismSample;

class Program{
  static void Main(string[] args){
    Animal[] animals = new Animal[]{ 
      new Dog(), 
      new Cat(),    
      new Wolf()
    };
    foreach(Animal animal in animals){
      Console.WriteLine(animal.makeSound());
    }
  }
}