using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Coffee.CoffeeMaker;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            StandartBoiler B = new StandartBoiler(1000, 2500);
            StandartWaterTank WT = new StandartWaterTank(5000);
            StandartCoffeeTank CT = new StandartCoffeeTank(3000);
            StandartMilkTank MT = new StandartMilkTank(3000);
            StandartSugarTank ST = new StandartSugarTank(2000);
            StandartCupCartridge CC = new StandartCupCartridge(1000);
            CoffeeMaker COFFEEMAKER = new CoffeeMaker(B, WT, CT, MT, ST, CC);
            COFFEEMAKER.MakeCoffee(CoffeeMaker.ButtonsType.americano);
            CoffeeMakerController Controller = new CoffeeMakerController();



            Dictionary<ButtonsType, Button> Buttons = new Dictionary<ButtonsType, Button>();
            initButtonsTemp(out Buttons);
            StandartKeyboard KB = new StandartKeyboard(Buttons);
            KB.ConnectToController(Controller);
            COFFEEMAKER.Keyboard = KB;

            COFFEEMAKER.Keyboard.Buttons[ButtonsType.americano].Press();
            COFFEEMAKER.Keyboard.Buttons[ButtonsType.cappuccino].Press();
            COFFEEMAKER.Keyboard.Buttons[ButtonsType.start].Press();
            COFFEEMAKER.Keyboard.Buttons[ButtonsType.cappuccino].Press();
            COFFEEMAKER.Keyboard.Buttons[ButtonsType.cappuccino].Press();

            Action<string> Vova;
            Action<int, int> Boris;
            Action Dasha;
            EventHandler Petya;
            Action1 Vala;
            Action2<string> Pasha;


            Dasha = () => { Console.WriteLine("test"); };
            Petya = (o, i) => { Console.WriteLine("{0} - {1}", o, i); };
            Vova = (i) => { Console.WriteLine(i); };
            Vala = (i) => { Console.WriteLine(i); };
            Pasha = (i) => {
                Console.WriteLine(i);
                return i;
            };
            Boris  = (i, j) => Console.WriteLine(i+j);

           



            // MyAction D = new MyAction((i) => Console.WriteLine(i));
            string t = default(string);
            Petya("test", new EventArgs());
            Vova("Привет от Вовы");
            Dasha();
            t = Pasha("475455");
            Boris(28, 37);
            Console.WriteLine(t);

            
           


        }

        public delegate void Action1(string s);
        public delegate T Action2<T>(T param);
        private static void WaterTank_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
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
