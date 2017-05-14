namespace Coffee {
    public interface ICupCartridge {
        int AmountOfCups { get; }

        int AddCup();
        int AddCups(int AmountOfCups);
        int TakeCup();
        int TakeCups(int AmountOfCups);
        int Fill();
    }
}