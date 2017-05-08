using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee
{
    public class CoffeeMaker {
        internal byte CurrentWaterTemperature {
            get => default(int);
            set {
            }
        }

        internal bool ConnectedToPower {
            get => default(bool);
            set {
            }
        }

        internal void MakeCoffee(CoffeeType type) {
            Console.WriteLine("Making coffee {0}", type.ToString());
        }

        public enum CoffeeType {
            espesso, americano, cappuccino
        }
    }
}