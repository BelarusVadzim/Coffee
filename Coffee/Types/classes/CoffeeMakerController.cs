using System;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class StandartCoffeeMakerController : ICoffeeMakerController {

        private const int maxSugar = 15; 
        public event EventHandler<string> StateChanged;
        private int sugar = default(int);
        private int coffeeBeans = default(int);
        private int water = default(int);
        private int milk = default(int);
        private bool waterIsEmpty = default(bool);
        private bool coffeeBeaansIsEmpty = default(bool);
        private bool milkIsEmpty = default(bool);
        private bool sugarIsEmpty = default(bool);
        private bool cupsIsEmpty = default(bool);


        private CoffeeType coffeeType = default(CoffeeType);
        protected IBoiler boiler = default(IBoiler);
        protected IWaterTank waterTank = default(IWaterTank);
        protected ICoffeeTank coffeeTank = default(ICoffeeTank);
        protected ISugarTank sugarTank = default(ISugarTank);
        protected ICupCartridge cupCartridge = default(ICupCartridge);
        protected IKeyboard keyboard = default(IKeyboard);
        protected IMilkTank milkTank = default(IMilkTank);

        private string waterErr = "", sugarErr = "", milkErr = "", coffeeBeansErr = "", systemErr = "", cupErr = "";

        public string Status {
            get { return string.Format("{0}/n{1}/n{2}/n{3}/n{4}/n{5/n}", waterErr, sugarErr, milkErr, coffeeBeansErr, systemErr, cupErr); }
        }

        public void Connect(IBoiler Boiler, IWaterTank WaterTank, ICoffeeTank CoffeeTank,
           IMilkTank MilkTank, ISugarTank SugarTank, ICupCartridge CupCartridge, IKeyboard Keyboard) {
            this.boiler = Boiler;
            this.waterTank = WaterTank;
            this.coffeeTank = CoffeeTank;
            this.milkTank = MilkTank;
            this.sugarTank = SugarTank;
            this.cupCartridge = CupCartridge;
            this.keyboard = Keyboard;
            this.keyboard.ConnectToController(this);
        }


        
       
      
       


        protected void MakeCoffee() {
            SetCoffeeType();
            PrepareCup();
            PrepareWater();
            PrepareCoffeeBeans();
            PrepareMilk();
            PrepareSugar();
            StateChanged(this, "Take your cup of coffee");
        }

        protected void SetCoffeeType() {

            switch (coffeeType) {
                case CoffeeType.Espesso:
                    SetUpCoffeeParams(150, 10, 0);
                    break;
                case CoffeeType.Americano:
                    SetUpCoffeeParams(250, 10, 0);
                    break;
                case CoffeeType.Cappuccino:
                    SetUpCoffeeParams(150, 10, 50);
                    break;
                default:
                    break;
            }
            StateChanged?.Invoke(this, string.Format("Coffe type is {0}", coffeeType));
        }

        private void SetUpCoffeeParams(int Water, int CoffeeBeans, int Milk) {
            water = Water;
            coffeeBeans = CoffeeBeans;
            milk = Milk;
        }

        protected void IncreaseSugar() {
            if (sugar < maxSugar) {
                sugar += 5;
                StateChanged?.Invoke(this, "Сахар увеличен");
            }
            else {
                sugar = maxSugar;
                StateChanged?.Invoke(this, "Максимальное количество сахара");
            }
        }

        protected void ReduceSugar() {
            if (sugar > 0) {
                sugar -= 5;
                StateChanged?.Invoke(this, "Сахар уменшен");
            }
            else {
                sugar = 0;
                StateChanged?.Invoke(this, "Без сахара");
            }
        }

        protected void PrepareWater() {
            if (!waterIsEmpty && water>0) {
                int tw = waterTank.TakeWater(water);
                if (tw < water) {
                    waterErr = "No water";
                    waterIsEmpty = true;
                    StateChanged?.Invoke(this, waterErr);
                }
                else {
                    boiler.AddWater(tw);
                    boiler.WarmUp(100);
                    tw = boiler.Drain();
                    StateChanged?.Invoke(this, string.Format("Boiled and drain to cup {0} mls of water", tw));
                }
            }
        }

        protected void PrepareCup() {
            if (!cupsIsEmpty) {
                int tc = cupCartridge.TakeCup();
                if (tc < 1) {
                    cupErr = "No cups";
                    cupsIsEmpty = true;
                    StateChanged?.Invoke(this, cupErr);
                }
                else {
                    StateChanged?.Invoke(this, "One cup has been prepeared.");
                }
                
            }
        }

        protected void PrepareCoffeeBeans() {
            if (!coffeeBeaansIsEmpty && coffeeBeans>0) {
                int tc = coffeeTank.TakeCoffee(coffeeBeans);
                if (tc < coffeeBeans) {
                    coffeeBeansErr = "No coffee beans";
                    coffeeBeaansIsEmpty = true;
                    StateChanged?.Invoke(this, coffeeBeansErr);
                }
                else {
                    StateChanged?.Invoke(this, string.Format("{0} mls of coffee has been prepeared", tc));
                }
            }
        }

        protected void PrepareMilk() {
            if (!milkIsEmpty && milk > 0) {
                int tm = milkTank.TakeMilk(milk);
                if (tm < milk) {
                    milkErr = "No milk";
                    milkIsEmpty = true;
                    StateChanged?.Invoke(this, milkErr);
                }
                else{
                    StateChanged?.Invoke(this, string.Format("{0} mls of milk has been prepeared", tm));
                }
            }
        }

        protected void PrepareSugar() {
            if (!sugarIsEmpty && sugar > 0) {
                int ts = sugarTank.TakeSugar(sugar);
                if (ts < sugar) {
                    sugarErr = "No sugar";
                    sugarIsEmpty = true;
                    StateChanged?.Invoke(this, sugarErr);
                }
                else {
                    StateChanged?.Invoke(this, string.Format("{0} mls of sugar has been prepeared", ts));
                }
            }
        }

        protected void ChangeState() {
            //throw new System.NotImplementedException();
        }



        public void InputCommand(ButtonsType CommandValue) {
            Console.WriteLine("Контроллер получил входящий параметр: {0}", CommandValue);
 
            switch (CommandValue) {
                case  ButtonsType.Start:
                    MakeCoffee();
                    break;
                case  ButtonsType.CoffeeType1:
                    coffeeType = CoffeeType.Americano;
                    break;
                case ButtonsType.CoffeeType2:
                    coffeeType = CoffeeType.Cappuccino;
                    break;
                case ButtonsType.CoffeeType3:
                    coffeeType = CoffeeType.Espesso;
                    break;
                case ButtonsType.IncreaseSugar:
                    IncreaseSugar();
                    break;
                case ButtonsType.ReduceSugar:
                    ReduceSugar();
                    break;
                default:
                    break;
            }
        }
    }
}