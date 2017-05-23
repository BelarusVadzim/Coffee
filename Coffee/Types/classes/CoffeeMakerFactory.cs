using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class CoffeeMakerFactory {
        public static CoffeeMaker CreateCoffeeMaker() {
            StandartBoiler B = new StandartBoiler(1000, 3500);
            StandartWaterTank WT = new StandartWaterTank(5000);
            StandartCoffeeTank CT = new StandartCoffeeTank(3000);
            StandartMilkTank MT = new StandartMilkTank(3000);
            StandartSugarTank ST = new StandartSugarTank(2000);
            StandartCupCartridge CC = new StandartCupCartridge(1000);

            
            StandartCoffeeMakerController CMC = new StandartCoffeeMakerController();
            Dictionary<ButtonsType, IButton> Buttons = new Dictionary<ButtonsType, IButton>();
            StandartKeyboard KB = new StandartKeyboard(InitButtonsTemp(Buttons));
            CoffeeMaker COFFEEMAKER = new CoffeeMaker(B, WT, CT, MT, ST, CC, CMC, KB);
            CMC.Connect(B, WT, CT, MT, ST, CC, KB);
            WT.Fill();
            CT.Fill();
            MT.Fill();
           // ST.Fill();
            CC.Fill();

            Console.WriteLine("CoffeeMaker has been created just now");
            Console.WriteLine(COFFEEMAKER.ToString());
            return COFFEEMAKER;
        }


        private static Dictionary<ButtonsType, IButton> InitButtonsTemp(Dictionary<ButtonsType, IButton> Buttons) {
            Buttons = new Dictionary<ButtonsType, IButton>();
            MakeButton(ButtonsType.CoffeeType2, Buttons);
            MakeButton(ButtonsType.CoffeeType3, Buttons);
            MakeButton(ButtonsType.CoffeeType1, Buttons);
            MakeButton(ButtonsType.IncreaseSugar, Buttons);
            MakeButton(ButtonsType.ReduceSugar, Buttons);
            MakeButton(ButtonsType.Start, Buttons);
            return Buttons;
        }
        private static void MakeButton(ButtonsType bt, Dictionary<ButtonsType, IButton> Buttons) {
            Buttons.Add(bt, new Button(bt, bt.ToString()));
        }
    }
}