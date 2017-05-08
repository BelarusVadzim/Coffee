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

        }

        private static void W_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }
}
