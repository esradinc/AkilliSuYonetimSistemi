using System;
using System.Collections.Generic;
using System.Text;
using TasarımKalıpları.Model;

namespace TasarımKalıpları
{
    public class WaterQualityMonitor : IObserver
    {
        public void Update(SensorData data)
        {
            if (data is WaterSensorData waterData)
            {
                Console.WriteLine($"WaterQualityMonitor received data from {data.Name} at {data.Timestamp}");
                Console.WriteLine(waterData);
                if (waterData.PH < 6.5 || waterData.PH > 8.5)
                {
                    Console.WriteLine($"ALERT: Abnormal pH level detected by {data.Name} with value {waterData.PH}");
                }
                if (waterData.TDS > 500)
                {
                    Console.WriteLine($"ALERT: High TDS level detected by {data.Name} with value {waterData.TDS}");
                }
                if (waterData.Turbidity > 5)
                {
                    Console.WriteLine($"ALERT: High turbidity detected by {data.Name} with value {waterData.Turbidity}");
                }
                if (waterData.Temperature > 35)
                {
                    Console.WriteLine($"ALERT: High temperature detected by {data.Name} with value {waterData.Temperature}");
                }
                if (waterData.DissolvedOxygen < 5)
                {
                    Console.WriteLine($"ALERT: Low dissolved oxygen detected by {data.Name} with value {waterData.DissolvedOxygen}");
                }
                if (waterData.Conductivity > 1500)
                {
                    Console.WriteLine($"ALERT: High conductivity detected by {data.Name} with value {waterData.Conductivity}");
                }
            }
        }
    }

}
