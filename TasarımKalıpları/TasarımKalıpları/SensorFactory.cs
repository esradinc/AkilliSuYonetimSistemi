using System;

public abstract class SensorFactory
{
    public abstract Sensor CreateSensor(string type, string name);
}

public class ConcreteSensorFactory : SensorFactory
{
    public override Sensor CreateSensor(string type, string name)
    {
        Console.WriteLine($"Creating sensor with type: {type} and name: {name}");
        switch (type)
        {
            case "Water":
                return new WaterSensor(name);
            case "Pressure":
                return new PressureSensor(name);
            default:
                throw new ArgumentException("Unknown sensor type");
        }
    }
}
