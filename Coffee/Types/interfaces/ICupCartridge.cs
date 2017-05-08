namespace Coffee {
    public interface ICupCartridge {
        int AmountOfCups { get; set; }

        int AddCups(int AmountOfCups);
        int TakeCup();
    }
}