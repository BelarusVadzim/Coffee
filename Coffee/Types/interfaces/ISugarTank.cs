namespace Coffee {
    public interface ISugarTank {
        int MaxSugarTankVolume { get; }
        bool IsEmpty { get; }
        int AddSugar();
        int AddSugar(int Amount);
        int TakeSugar();
        int TakeSugar(int Amount);
        int Fill();
    }
}