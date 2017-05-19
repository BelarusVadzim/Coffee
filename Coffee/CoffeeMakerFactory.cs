using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class CoffeeMakerFactory {
        public static CoffeeMaker CreateCoffeeMaker() {
            StandartBoiler B = new StandartBoiler(1000, 2500);
            StandartWaterTank WT = new StandartWaterTank(5000);
            StandartCoffeeTank CT = new StandartCoffeeTank(3000);
            StandartMilkTank MT = new StandartMilkTank(3000);
            StandartSugarTank ST = new StandartSugarTank(2000);
            StandartCupCartridge CC = new StandartCupCartridge(1000);
            CoffeeMakerController CMC = new CoffeeMakerController();

            Dictionary<ButtonsType, Button> Buttons = new Dictionary<ButtonsType, Button>();
            StandartKeyboard KB = new StandartKeyboard(Buttons);
            KB.ConnectToController(CMC);





            initButtonsTemp(out Buttons);
            KB.ConnectToController(CMC);
            CoffeeMaker COFFEEMAKER = new CoffeeMaker(B, WT, CT, MT, ST, CC);
            return COFFEEMAKER;
        }

        private static void initButtonsTemp(out Dictionary<ButtonsType, Button> Buttons) {
            Buttons = new Dictionary<ButtonsType, Button>();
            MakeButton(ButtonsType.americano, Buttons);
            MakeButton(ButtonsType.cappuccino, Buttons);
            MakeButton(ButtonsType.espesso, Buttons);
            MakeButton(ButtonsType.inSugar, Buttons);
            MakeButton(ButtonsType.deSugar, Buttons);
            MakeButton(ButtonsType.start, Buttons);
        }
        private static void MakeButton(ButtonsType bt, Dictionary<ButtonsType, Button> Buttons) {
            Buttons.Add(bt, new Button(bt, bt.ToString()));
        }
    }
}