using System;
using System.Collections.Generic;

public class ControlCenter
{
    private static ControlCenter _instance;
    private List<Sensor> sensors;

    private ControlCenter()
    {
        sensors = new List<Sensor>();
        Console.WriteLine("ControlCenter initialized.");
    }

    public static ControlCenter Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new ControlCenter();
                Console.WriteLine("ControlCenter instance created.");
            }
            return _instance;
        }
    }

    public void AddSensor(Sensor sensor)
    {
        sensors.Add(sensor);
        Console.WriteLine($"Sensor {sensor.Name} added to ControlCenter.");
    }

    public void NotifySensors()
    {
        Console.WriteLine("Notifying all sensors to update data...");
        foreach (var sensor in sensors)
        {
            sensor.Update();
        }
    }
}
