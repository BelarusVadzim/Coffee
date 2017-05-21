namespace Coffee {
    public interface IWaterTank {
        int MaxWaterTankVolume { get; }
        int CoffeeVolume { get; }
        bool IsEmpty { get; }
        int AddWater();
        int AddWater(int Amount);
        int TakeWater();
        int TakeWater(int Amount);
        int Fill();
    }
}