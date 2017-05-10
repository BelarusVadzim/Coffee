namespace Coffee {
    public interface ICupCartridge {
        int AmountOfCups { get; }

        int AddCups(int AmountOfCups);
        int TakeCup();
    }
}