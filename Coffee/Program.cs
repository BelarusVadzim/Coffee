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
            CoffeeMaker COFFEEMAKER = CoffeeMakerFactory.CreateCoffeeMaker();

            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType2].Press();
            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType3].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.ReduceSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.Start].Press();
            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType3].Press();
            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType1].Press();





            //----------------------------Tests-----------------------------------

            Console.WriteLine("--------Tests-----------------------");

            
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

        private static void InitButtonsTemp(out Dictionary<ButtonsType, Button> Buttons) {
            Buttons = new Dictionary<ButtonsType, Button>();
            MakeButton(ButtonsType.CoffeeType2, Buttons);
            MakeButton(ButtonsType.CoffeeType3, Buttons);
            MakeButton(ButtonsType.CoffeeType1, Buttons);
            MakeButton(ButtonsType.IncreaseSugar, Buttons);
            MakeButton(ButtonsType.ReduceSugar, Buttons);
            MakeButton(ButtonsType.Start, Buttons);
        }
        private static void MakeButton(ButtonsType bt, Dictionary<ButtonsType, Button> Buttons) {
            Buttons.Add(bt, new Button(bt, bt.ToString()));
        }


    }

    
}
