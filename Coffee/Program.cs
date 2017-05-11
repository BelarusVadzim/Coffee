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
            CoffeeMaker maker = new CoffeeMaker();
            maker.MakeCoffee(CoffeeMaker.CoffeeType.cappuccino);
            StandartWaterTank SWT = new StandartWaterTank(1000);
            Water W1 = new Water(500, 0);
            Water W2 = new Water(500, 40);
            SWT.AddWater(W1);
            Console.WriteLine(SWT.ToString());
            //  SWT.AddWater(W);
            // Console.WriteLine(SWT.CurrentAmountOfWater);
            Console.WriteLine(W1.ToString());
            Console.WriteLine(W2.ToString());
            W1.Add(W2);
            Console.WriteLine(W1.ToString());
            W2 = W1.Subtraction(900);
            Console.WriteLine(W1.ToString());
            Console.WriteLine(W2.ToString());


        }

        private static void W_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }

    
}
