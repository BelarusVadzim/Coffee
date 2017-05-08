using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public interface IElectricDevice {
        bool IsPowered { get; }

        void SwitchOn();
        void SwitchOff();
    }
}