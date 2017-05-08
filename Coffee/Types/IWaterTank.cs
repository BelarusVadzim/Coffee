using System;

namespace Coffee {
    public interface IWaterTank {
        int AmountOfWater { get; set; }
        int FullVolume { get; }
        bool IsEmpty { get; set; }
        bool IsFull { get; set; }

        event EventHandler TankIsEmpty;
        event EventHandler TankIsFull;

        int AddWater();
        int AddWater(int AmountOfWaterToAdd);
        int TakeWater();
        int TakeWater(int AmountOfWaterToTake);
    }
}