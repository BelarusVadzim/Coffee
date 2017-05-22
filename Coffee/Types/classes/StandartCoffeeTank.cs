using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartCoffeeTank : Tank, ICoffeeTank {

        /// <summary>
        /// Объм коффе в контейнере
        /// </summary>
        public int CoffeeVolume {
            get { return base.ContentVolume; }
        }

        /// <summary>
        /// Максимальный объм коффе в контейнере
        /// </summary>
        public int MaxCoffeeTankVolume {
            get { return base.MaximumVolume; }
        }

        public StandartCoffeeTank(int MaximumVolume) : base(MaximumVolume) {
        }

        public int TakeCoffee(int Amount) {
        
            return base.Take(Amount);
        }

        public int TakeCoffee() {
            return base.Take();
        }

        public int AddCoffee() {
            return base.Add();
        }

        public int AddCoffee(int Amount) {
            return base.Add(Amount);
        }

        public override int Fill() {
            return base.Fill();
        }


        public override string ToString() {
            return string.Format("MaximumVolume: {0}, ContentVolume: {1}, IsFull: {2}, IsEmpty: {3} ",
                this.MaximumVolume, this.ContentVolume, IsFull, IsEmpty);
        }
    }
}