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
            COFFEEMAKER.MakeCoffee(CoffeeMaker.CoffeeType.americano);
            CoffeeMakerController Controller = new CoffeeMakerController();

            List<Button> Buttons = new List<Button>() { new Button(1, "one"), new Button(2, "two"), new Button(3, "Three") };
            Keyboard KB = new Keyboard(Buttons);
            KB.ConnectToController(Controller);
            COFFEEMAKER.StandartKeyboard = KB;

            COFFEEMAKER.StandartKeyboard.Buttons[0].Press();
            COFFEEMAKER.StandartKeyboard.Buttons[1].Press();
            COFFEEMAKER.StandartKeyboard.Buttons[2].Press();

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

            Dictionary<CoffeeType, Button> kbd = new Dictionary<CoffeeType, Button>();
            kbd.Add(CoffeeType.americano, COFFEEMAKER.StandartKeyboard.Buttons[0]);
            kbd.Add(CoffeeType.cappuccino, COFFEEMAKER.StandartKeyboard.Buttons[1]);
            kbd.Add(CoffeeType.espesso, COFFEEMAKER.StandartKeyboard.Buttons[2]);
            kbd[ CoffeeType.espesso ].Press();


        }

        public delegate void Action1(string s);
        public delegate T Action2<T>(T param);
        private static void WaterTank_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }

    
}
