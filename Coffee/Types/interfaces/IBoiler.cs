namespace Coffee {
    public interface IBoiler {
        int MaxBoilerVolume { get; }
        int Power { get; }
        int WaterVolume { get; }

        void AddWater(int AmountToAdd);
        int Drain();
        double WarmUp(double TargetTemperature);
    }
}