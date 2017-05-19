using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Coffee {
    public class StandartBoiler : Tank, IBoiler {

        private const int ambientTemperature = 20; // Пока константа, затем добавлю возможность менять
        private const double heatCapacity = 4.187;

        /// <summary>
        /// Объм воды в бойлере
        /// </summary>
        public int WaterVolume {
            get { return base.ContentVolume; }
        }

        /// <summary>
        /// Максимальный объм воды в бойлере
        /// </summary>
        public int MaxBoilerVolume {
            get {return base.MaximumVolume; }
        }
        

        /// <summary>
        /// Мощность бойлера.
        /// </summary>
        public int Power { get; private set; }
        
        public void AddWater(int AmountToAdd) {
            base.Add(AmountToAdd);
        }


        public StandartBoiler(int FullVolume, int Power) : base(FullVolume) {
            this.Power = Power;
        }

        public double WarmUp(double TargetTemperature) {
            if (WaterVolume == 0) return 0;
            double result = default(double); 
            result = (double)ContentVolume/1000 * (TargetTemperature - ambientTemperature) * 4187 / Power;

            Console.WriteLine("В бойлере {0} мл воды", ContentVolume);
            Console.WriteLine("Boiler => {0} mls of {1} C° water take {2} sec for Warming up to {3} C° ", 
                ContentVolume, ambientTemperature, result, TargetTemperature);
            Console.WriteLine((int)(result * 1000));
            Thread.Sleep((int)(result * 1000));
            Console.WriteLine("Вода нагрелась");
            return result;
            
        }

        public int Drain() {
            return base.Take(ContentVolume);
        }

        public override string ToString() {
            return string.Format("Boiler => MaximumVolume: {0}, ContentVolume: {1}, Power: {2}, IsFull: {3}, IsEmpty: {4}",
                this.MaxBoilerVolume, this.WaterVolume, this.Power, IsFull, IsEmpty);
        }
    }
}