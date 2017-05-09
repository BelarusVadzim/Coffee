using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public interface ICoffeeTank {
        int AmountOfCoffee { get; set; }
        int MaximumVolume { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }

        event EventHandler TankIsEmpty;
        event EventHandler TankIsFull;

        int AddCoffee();
        int AddCoffee(int AmountOfCoffeeToAdd);
        int TakeCoffee();
        int TakeCoffee(int AmountOfCoffeeToTake);
    }
}