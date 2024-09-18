using System.Collections.Generic;

public class Station : ISubject
{
  private List<IObserver> _observers;
  private float _temperature;

  public Station()
  {
    _observers = new List<IObserver>();
  }

  public void AddObserver(IObserver observer)
  {
    _observers.Add(observer);
  }

  public void RemoveObserver(IObserver observer)
  {
    _observers.Remove(observer);
  }

  public void NotifyObservers(){
    foreach(IObserver observer in _observers)
    {
      observer.Update(_temperature);
    }
  }

  public void SetTemperature(float temperature)
  {
    _temperature = temperature;
    NotifyObservers();
  }
}