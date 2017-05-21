﻿namespace Coffee {
    public interface ICoffeeTank {
        int CoffeeVolume { get; }
        int MaxCoffeeTankVolume { get; }
        bool IsEmpty { get; }
        int AddCoffee();
        int AddCoffee(int Amount);
        int TakeCoffee();
        int TakeCoffee(int Amount);
        int Fill();
    }
}