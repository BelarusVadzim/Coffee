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

        public StandartKeyboard Keyboard { get; set; }


        //private IWaterTank WaterTank { get; set; }
        //private ICoffeeTank CoffeeTank { get; set; }
        //private ICupCartridge CupCartridge { get; set; }
        //private IMilkTank MilkTank { get; set; }
        //private ISugarTank SugarTank{ get; set; }


        public CoffeeMaker(IBoiler Boiler, IWaterTank WaterTank, ICoffeeTank CoffeeTank,
            IMilkTank MilkTank, ISugarTank SugarTank, ICupCartridge CupCartridge) {
            this.Boiler = Boiler;
            this.WaterTank = WaterTank;
            this.CoffeeTank = CoffeeTank;
            this.MilkTank = MilkTank;
            this.SugarTank = SugarTank;
            this.CupCartridge = CupCartridge;
        }

        public void SwitchOff() {
            IsPowered = false;
        }
        public void SwitchOn() {
            IsPowered = true;
        }




        internal void MakeCoffee(ButtonsType type) {

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

        public enum ButtonsType {
            espesso = 0,
            americano = 1,
            cappuccino = 2,
            inSugar = 3,
            deSugar = 4,
            start =5
        }
    }
}