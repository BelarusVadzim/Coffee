namespace Coffee {
    public interface ISugarTank {
        int AmountOfSugar { get; set; }

        int AddSugar();
        int AddSugar(int AmountOfSugarToAdd);
        int TakeSugar();
        int TakeSugar(int AmountOfSugarToTake);
    }
}