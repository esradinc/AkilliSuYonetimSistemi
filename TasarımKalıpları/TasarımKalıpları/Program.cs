using System;
using TasarımKalıpları;

class Program
{
    static void Main()
    {
        Console.WriteLine("Starting Smart Water Management System...");

        // Singleton instance of ControlCenter
        ControlCenter controlCenter = ControlCenter.Instance;

        // Factory for creating sensors
        SensorFactory factory = new ConcreteSensorFactory();

        // Create sensors using factory
        Sensor sensor1 = factory.CreateSensor("Water", "Sensor 1");
        Sensor sensor2 = factory.CreateSensor("Pressure", "Sensor 2");

        // Create observers
        WaterQualityMonitor waterMonitor = new WaterQualityMonitor();
        PressureMonitor pressureMonitor = new PressureMonitor();

        // Attach observers to sensors
        sensor1.AddObserver(waterMonitor);
        sensor2.AddObserver(pressureMonitor);

        // Add sensors to control center
        controlCenter.AddSensor(sensor1);
        controlCenter.AddSensor(sensor2);

        // Notify sensors to generate and report data
        controlCenter.NotifySensors();

        Console.WriteLine("Smart Water Management System operations completed.");
    }
}
