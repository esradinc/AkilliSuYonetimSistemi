using System;
using System.Collections.Generic;
using TasarımKalıpları.Model;
using TasarımKalıpları;

public abstract class Sensor
{
    private List<IObserver> observers;
    public string Name { get; }

    protected Sensor(string name)
    {
        Name = name;
        observers = new List<IObserver>();
        Console.WriteLine($"Sensor {name} created.");
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
        Console.WriteLine($"Observer added to {Name}.");
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
        Console.WriteLine($"Observer removed from {Name}.");
    }

    public void NotifyObservers(SensorData data)
    {
        Console.WriteLine($"{Name} is notifying observers...");
        foreach (var observer in observers)
        {
            observer.Update(data);
        }
    }

    public void Update()
    {
        SensorData data = GetData();
        Console.WriteLine($"{Name} generated data: {data}");
        NotifyObservers(data);
    }

    protected abstract SensorData GetData();
}
