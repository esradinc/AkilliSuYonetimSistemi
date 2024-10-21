using System;
using System.Collections.Generic;
using System.Text;
using TasarımKalıpları.Model;

namespace TasarımKalıpları
{
    public interface IObserver
    {
        void Update(SensorData data);
    }
}
