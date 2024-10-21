using System;
using System.Collections.Generic;
using System.Text;

namespace TasarımKalıpları.Model
{
    public class SensorData
    {
        public string Name { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}
