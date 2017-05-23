using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartWaterTank : Tank, IWaterTank {

        /// <summary>
        /// Объм воды в бойлере
        /// </summary>
        public int CoffeeVolume {
            get { return base.ContentVolume; }
        }

        /// <summary>
        /// Максимальный объм воды в бойлере
        /// </summary>
        public int MaxWaterTankVolume {
            get { return base.MaximumVolume; }
        }

        public new bool IsEmpty {
            get { return base.IsEmpty; }
        }

        public StandartWaterTank(int MaximumVolume) : base(MaximumVolume) {
        }

        public int TakeWater(int Amount) {
            return base.Take(Amount);
        }

        public int TakeWater() {
            return base.Take();
        }

        public int AddWater() {
            return base.Add();
        }

        public int AddWater(int Amount) {
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