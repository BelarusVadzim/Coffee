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
            Boiler B = new Boiler(1000, 1000);
            Console.WriteLine(B.ToString());
            B.AddWater(1700);
            Console.WriteLine(B.ToString());
            B.WarmUp(100);
            Console.WriteLine(B.ToString());
            B.Drain();
            Console.WriteLine(B.ToString());

        }

        private static void WaterTank_TankIsFull(object sender, EventArgs e) {
            Console.WriteLine("Tank is Full");
        }

        private static void W_TankIsEmpty(object sender, EventArgs e) {
            Console.WriteLine("Tank is Empty");
        }
    }

    
}
