﻿namespace Coffee {
    public interface IMilkTank {
        int MaxMilkTankVolume { get; }
        int MilkVolume { get; }

        int AddMilk();
        int AddMilk(int Amount);
        int TakeMilk();
        int TakeMilk(int Amount);
    }
}