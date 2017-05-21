using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee
{
    public class CoffeeMaker: IElectricDevice {
        public bool IsPowered { get; private set; }

        internal byte CurrentWaterTemperature { get; set; }

        protected IBoiler Boiler { get; }
        protected IWaterTank WaterTank { get; }
        protected ICoffeeTank CoffeeTank { get; }
        protected IMilkTank MilkTank { get; }
        protected ISugarTank SugarTank { get; }
        protected ICupCartridge CupCartridge { get; }
        public    IKeyboard Keyboard { get; }
        protected ICoffeeMakerController Controller { get;}

        public CoffeeMaker(IBoiler Boiler, IWaterTank WaterTank, ICoffeeTank CoffeeTank,
            IMilkTank MilkTank, ISugarTank SugarTank, ICupCartridge CupCartridge, 
            ICoffeeMakerController CMC, IKeyboard Keyboard) {
            this.Boiler = Boiler;
            this.WaterTank = WaterTank;
            this.CoffeeTank = CoffeeTank;
            this.MilkTank = MilkTank;
            this.SugarTank = SugarTank;
            this.CupCartridge = CupCartridge;
            this.Controller = CMC;
            this.Keyboard = Keyboard;
            CMC.StateChanged += (o, i) => Console.WriteLine(i);
        }

        public void SwitchOff() {
            IsPowered = false;
        }
        public void SwitchOn() {
            IsPowered = true;
        }




        protected void MakeCoffee(ButtonsType type) {

            int water = default(int);
            Console.WriteLine(WaterTank.ToString());
            water = WaterTank.Fill();
            Console.WriteLine("Добавлено {0} мл", water);
            Console.WriteLine(WaterTank.ToString());
            water = WaterTank.TakeWater(200);
            Boiler.AddWater(water);
            Boiler.WarmUp(100);
            Console.WriteLine("Making coffee {0}", type.ToString());
        }

        public override string ToString() {
            return string.Format("Boiler = {0}; \nWaterTank = {1}; \nCoffeeTank = {2}; \nMilkTank = {3}; " +
                "\nSugarTank = {4}; \nCupCartridge = {5}; \nKeyboard = {6}; \nController = {7}; \nIsPowered = {8}; \nCurrentWaterTemperature = {9}", 
                Boiler.ToString(), WaterTank.ToString(), CoffeeTank.ToString(), MilkTank.ToString(), SugarTank.ToString(),
                CupCartridge.ToString(), Keyboard.ToString(), Controller.ToString(), IsPowered, CurrentWaterTemperature);
        }




        public enum ButtonsType {
            CoffeeType1 = 0,
            CoffeeType2 = 1,
            CoffeeType3 = 2,
            IncreaseSugar = 3,
            ReduceSugar = 4,
            Start =5
        }

        public enum CoffeeType {
            Espesso = 0,
            Americano = 1,
            Cappuccino = 2,
        }
    }
}