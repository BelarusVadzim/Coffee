using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class ButtonPressedEventArgs: EventArgs {
        public string Message {
            get => default(string);
            set {
            }
        }

        public int ButtonValue {
            get => default(int);
            set {
            }
        }
    }

    public class WaterVolumeChangedEventArgs : EventArgs {
        public string Message { get; set; }
        public int NewVolume { get; set; }
        public int OldVolume { get; set; }
        public WaterVolumeChangedEventArgs() {
            Message = default(string);
            NewVolume = default(int);
            OldVolume = default(int);
        }
    }

    public class WaterTemperatureChangedEventArgs : EventArgs {
        public string Message {
            get => default(string);
            set {
            }
        }

        public double NewTemperature {
            get => default(int);
            set {
            }
        }

        public double OldTemperature {
            get => default(int);
            set {
            }
        }
    }
}