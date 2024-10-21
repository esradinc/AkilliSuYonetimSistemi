using System;
using TasarımKalıpları.Model;

public class PressureSensor : Sensor
{
    public PressureSensor(string name) : base(name) { }

    protected override SensorData GetData()
    {
        Random random = new Random();
        var data = new PressureSensorData
        {
            Name = Name,
            Timestamp = DateTime.Now,
            Pressure = random.NextDouble() * 200 // Basınç değeri
        };
        return data;
    }
}
