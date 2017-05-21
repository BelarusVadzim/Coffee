namespace Coffee {
    public interface ICupCartridge {
      
        bool IsEmpty { get; }
        int AddCup();
        int AddCups(int AmountOfCups);
        int TakeCup();
        int TakeCups(int AmountOfCups);
        int Fill();
    }
}