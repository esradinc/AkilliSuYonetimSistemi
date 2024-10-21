using System;
using TasarımKalıpları.Model;
using TasarımKalıpları;

public class PressureMonitor : IObserver
{
    public void Update(SensorData data)
    {
        if (data is PressureSensorData pressureData)
        {
            Console.WriteLine($"PressureMonitor received data from {data.Name} at {data.Timestamp}");
            Console.WriteLine(pressureData);
            if (pressureData.Pressure > 150)
            {
                Console.WriteLine($"ALERT: High pressure detected by {data.Name} with value {pressureData.Pressure}");
            }
        }
    }
}
