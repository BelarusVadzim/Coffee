namespace Coffee {
    public interface IMilkTank {
        int AmountOfMilk { get; }

        int AddMilk();
        int AddMilk(int AmountOfMilkToAdd);
        int TakeMilk();
        int TakeMilk(int AmountOfMilkToTake);
    }
}