using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee
{
    public class CoffeeMaker: IElectricDevice {
        public bool IsPowered { get; private set; }

        internal byte CurrentWaterTemperature {
            get => default(int);
            set {
                CurrentWaterTemperature = value;
            }
        }

        internal bool ConnectedToPower {
            get => default(bool);
            set {
            }
        }

        private IWaterTank WaterTank {
            get => default(IWaterTank);
            set {
            }
        }

        ICoffeeTank CoffeeTank {
            get => default(ICoffeeTank);
            set {
            }
        }

        public void SwitchOff() {
            IsPowered = false;
        }

        public void SwitchOn() {
            IsPowered = true;
        }

        internal void MakeCoffee(CoffeeType type) {
            Console.WriteLine("Making coffee {0}", type.ToString());
        }

        public enum CoffeeType {
            espesso, americano, cappuccino
        }
    }
}