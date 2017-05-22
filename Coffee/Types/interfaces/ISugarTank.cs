namespace Coffee {
    public interface ISugarTank {
        int MaxSugarTankVolume { get; }
        int AddSugar();
        int AddSugar(int Amount);
        int TakeSugar();
        int TakeSugar(int Amount);
        int Fill();
    }
}