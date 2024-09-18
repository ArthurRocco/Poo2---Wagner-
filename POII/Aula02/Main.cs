using System; 

public class Program {

  public static void Main(string[] args) {
    Address person_address = new Address(
      "Avenida Comissário José Dantas de Melo", 
      21, 
      "Boa Vista II", 
      "Vila Velha", 
      "ES", 
      "29102-920"
    );

    Person person = new Person("John", "Doe", "ztejd@example.com", person_address);
    try{
      person.Age = -5;
      person.Print();
    }
    catch(Exception e){
      Console.WriteLine(e.Message);
    }
  }
}