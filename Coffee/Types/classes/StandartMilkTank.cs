using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartMilkTank : Tank, IMilkTank {




        public new bool IsEmpty {
            get { return base.IsEmpty; }
        }

        /// <summary>
        /// Объм воды в бойлере
        /// </summary>
        public int MilkVolume {
            get { return base.ContentVolume; }
        }

        /// <summary>
        /// Максимальный объм воды в бойлере
        /// </summary>
        public int MaxMilkTankVolume {
            get { return base.MaximumVolume; }
        }

        public StandartMilkTank(int MaximumVolume) : base(MaximumVolume) {
        }

        public int TakeMilk(int Amount) {
            return base.Take(Amount);
        }

        public int TakeMilk() {
            return base.Take();
        }

        public int AddMilk() {
            return base.Add();
        }

        public int AddMilk(int Amount) {
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