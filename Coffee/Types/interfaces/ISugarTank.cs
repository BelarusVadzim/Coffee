namespace Coffee {
    public interface ISugarTank {
        int AmountOfSugar { get; }

        int AddSugar();
        int AddSugar(int AmountOfSugarToAdd);
        int TakeSugar();
        int TakeSugar(int AmountOfSugarToTake);
    }
}