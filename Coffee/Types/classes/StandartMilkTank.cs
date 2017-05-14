using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartMilkTank : Tank, IMilkTank {

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
            Mark("!!");
            return base.Take(Amount);
        }

        public int TakeMilk() {
            Mark();
            return base.Take();
        }

        public int AddMilk() {
            Mark();
            return base.Add();
        }

        public int AddMilk(int Amount) {
            Mark();
            return base.Add(Amount);
        }

        public override int Fill() {
            return base.Fill();
        }


        public override string ToString() {
            return string.Format("WaterTank => MaximumVolume: {0}, ContentVolume: {1}, IsFull: {2}, IsEmpty: {3} ",
                this.MaximumVolume, this.ContentVolume, IsFull, IsEmpty);
        }

        private void Mark() {
            Console.WriteLine("MilkTank =>");
        }

        private void Mark(string s) {
            Console.WriteLine(s);
        }

    }
}