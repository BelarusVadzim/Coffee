﻿using System;

namespace Coffee {
    public interface IWaterTank {
        int AmountOfWater { get; set; }
        int MaxAmount { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }

        event EventHandler TankIsEmpty;
        event EventHandler TankIsFull;

        int AddWater();
        int AddWater(int AmountOfWaterToAdd);
        int TakeWater();
        int TakeWater(int AmountOfWaterToTake);
    }
}