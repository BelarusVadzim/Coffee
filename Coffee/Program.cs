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
            Liquid W = new Liquid(Liquid.LiquidType.Water, 300, 20);
            
            Console.WriteLine(W.Volume);
            
            Console.WriteLine(W.Mass);
        }

        private static void W_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }
}
