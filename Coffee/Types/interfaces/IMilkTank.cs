namespace Coffee {
    public interface IMilkTank {
        int AmountOfMilk { get; set; }

        int AddMilk();
        int AddMilk(int AmountOfMilkToAdd);
        int TakeMilk();
        int TakeMilk(int AmountOfMilkToTake);
    }
}