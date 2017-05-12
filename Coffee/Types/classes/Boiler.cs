using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Coffee {
    public class Boiler : StandartWaterTank {

        private const int AmbientTemperature = 20;
       // private int mass = 0;
        private const double HeatCapacity = 4.187;




        /// <summary>
        /// Мощность бойлера.
        /// </summary>
        public int Power { get; private set; }
        


        public Boiler(int FullVolume, int Power) : base(FullVolume) {
            this.Power = Power;
        }

        private void test(object O) {

        }

        public double WarmUp(double Temperature) {
            double result = default(double);
            Timer T = new Timer(test);
            result = (double)ContentVolume/1000 * (Temperature - AmbientTemperature) * 4187 / Power;
            return result;
            
        }

        public void Drain() {
            
        }
    }
}