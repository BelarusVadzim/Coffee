using System;

namespace Coffee {
    public interface IWaterTank {
        double CurrentAmountOfWater { get; }
        double MaximumVolume { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }

        event EventHandler TankIsEmpty;
        event EventHandler TankIsFull;

        double AddWater();
        double AddWater(double AmountOfWaterToAdd);
        double TakeWater();
        double TakeWater(double AmountOfWaterToTake);
    }
}