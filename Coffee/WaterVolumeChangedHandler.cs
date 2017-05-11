using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public delegate void WaterVolumeChangedHandler(object Sender, WaterVolumeChangedEventArgs Args);

    public delegate void WaterTemperatureChangedHandler(object Sender, Coffee.WaterTemperatureChangedEventArgs Args);
}