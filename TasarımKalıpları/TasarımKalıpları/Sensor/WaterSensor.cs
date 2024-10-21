using System;
using TasarımKalıpları.Model;

public class WaterSensor : Sensor
{
    public WaterSensor(string name) : base(name) { }

    protected override SensorData GetData()
    {
        Random random = new Random();
        var data = new WaterSensorData
        {
            Name = Name,
            Timestamp = DateTime.Now,
            PH = random.NextDouble() * 14, // pH değeri 0-14 aralığında
            TDS = random.Next(0, 1000), // TDS değeri
            Turbidity = random.NextDouble() * 100, // Bulanıklık değeri
            Temperature = random.NextDouble() * 40, // Sıcaklık değeri 0-40°C aralığında
            DissolvedOxygen = random.NextDouble() * 20, // Çözünmüş oksijen değeri
            Conductivity = random.NextDouble() * 2000 // İletkenlik değeri
        };
        return data;
    }
}
