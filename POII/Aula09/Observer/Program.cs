public class Program
{
  public static void Main(string[] args)
  {
    Station s = new Station();

    Monitor m1 = new Monitor();
    Monitor m2 = new Monitor();

    s.AddObserver(m1);
    s.AddObserver(m2);

    s.SetTemperature(27.5f);
    s.SetTemperature(26.0f);

    s.RemoveObserver(m1);
    s.SetTemperature(26.5f);
  }
}