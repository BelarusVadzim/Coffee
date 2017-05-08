﻿using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartCoffeeTank : Tank, ICoffeeTank {
        public StandartCoffeeTank(int FullVolume) : base(FullVolume) {
        }

        public int AmountOfCoffee {
            get { return Amount; }
            set { Amount = value; }
        }

        public int AddCoffee() {
            return Add();
        }

        public int AddCoffee(int AmountOfCoffeeToAdd) {
            return Add(AmountOfCoffeeToAdd);
        }

        public int TakeCoffee() {
            return Take();
        }

        public int TakeCoffee(int AmountOfCoffeeToTake) {
            return Take(AmountOfCoffeeToTake);
        }
    }
}