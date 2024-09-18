using System;

public class Person {
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public string Mail { get; set; }
  public Address Address { get; set; }
  private int _age;
  public int Age { 
    get {return _age; }
    set {
      if(value < 0){
        throw new Exception("Age cannot be negative");
      }
      _age = value;
    } 
  }

  public Person(string firstName, string lastName, string mail, Address address){
    FirstName = firstName;
    LastName = lastName;
    Mail = mail;
    Address = address;
  }

  public void Print(){
    Console.WriteLine($"Name: {FirstName} {LastName}");
    Console.WriteLine($"e- Mail: {Mail}");
    Console.WriteLine($"Address: {Address.Street}, {Address.Number} - {Address.Neighborhood},{Address.City}/{Address.State} - CEP: {Address.ZIP}");
    Console.WriteLine($"Age: {Age}");
  }
}