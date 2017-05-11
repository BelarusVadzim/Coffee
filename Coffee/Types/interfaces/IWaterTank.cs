using System;

namespace Coffee {
    public interface IWaterTank {
        int AmountOfContent { get; }
        int MaximumVolume { get; }
        bool IsEmpty { get; }
        bool IsFull { get; }

        event EventHandler TankIsEmpty;
        event EventHandler TankIsFull;

        //double AddWater();
        //double AddWater(double AmountOfWaterToAdd);
        int TakeWater();
        int TakeWater(int AmountOfWaterToTake);
    }
}