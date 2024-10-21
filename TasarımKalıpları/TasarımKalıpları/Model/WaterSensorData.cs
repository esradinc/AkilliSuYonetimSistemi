using System;
using System.Collections.Generic;
using System.Text;

namespace TasarımKalıpları.Model
{
    public class WaterSensorData : SensorData
    {
        public double PH { get; set; }
        public int TDS { get; set; }
        public double Turbidity { get; set; }
        public double Temperature { get; set; }
        public double DissolvedOxygen { get; set; }
        public double Conductivity { get; set; }

        public override string ToString()
        {
            return $"[WaterSensorData] PH: {PH}, TDS: {TDS}, Turbidity: {Turbidity}, Temperature: {Temperature}, Dissolved Oxygen: {DissolvedOxygen}, Conductivity: {Conductivity}";
        }
    }

}
