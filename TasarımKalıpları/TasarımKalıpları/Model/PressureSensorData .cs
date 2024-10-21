using System;
using System.Collections.Generic;
using System.Text;

namespace TasarımKalıpları.Model
{
    public class PressureSensorData : SensorData
    {
        public double Pressure { get; set; }

        public override string ToString()
        {
            return $"[PressureSensorData] Pressure: {Pressure}";
        }
    }
}
