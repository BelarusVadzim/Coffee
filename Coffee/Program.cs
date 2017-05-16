using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            CoffeeMaker CM = new CoffeeMaker(B, WT, CT, MT, ST, CC);
            CM.MakeCoffee(CoffeeMaker.CoffeeType.americano);
            CoffeeMakerController Controller = new CoffeeMakerController();

            List<Button> Buttons = new List<Button>() { new Button(1, "one"), new Button(2, "two"), new Button(3, "Three") };
            Keyboard KB = new Keyboard(Buttons);
            Controller.KeyBoard = KB;
            KB.Buttons[0].Press();
            KB.Buttons[1].Press();
            KB.Buttons[2].Press();

            //Console.WriteLine(WT.ToString());

        }

        private static void WaterTank_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }

    
}
