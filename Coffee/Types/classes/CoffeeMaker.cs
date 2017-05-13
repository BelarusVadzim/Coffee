using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee
{
    public class CoffeeMaker: IElectricDevice {
        public bool IsPowered { get; private set; }

        internal byte CurrentWaterTemperature { get; set; }

        //private IWaterTank WaterTank { get; set; }
        //private ICoffeeTank CoffeeTank { get; set; }
        //private ICupCartridge CupCartridge { get; set; }
        //private IMilkTank MilkTank { get; set; }
        //private ISugarTank SugarTank{ get; set; }


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