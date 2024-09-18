using System;

public class Address{
  public string Street { get; set; }
  public int Number { get; set; }
  public string Neighborhood { get; set; }
  public string City { get; set; }
  public string State { get; set; }
  public string ZIP { get; set; }


  public Address(string street, int number, string neighborhood, string city, string state, string zip){
    Street = street;
    Number = number;
    Neighborhood = neighborhood;
    City = city;
    State = state;
    ZIP = zip;
  }
}