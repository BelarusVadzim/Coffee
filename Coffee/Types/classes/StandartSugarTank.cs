using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartSugarTank : Tank, ISugarTank {

        /// <summary>
        /// Объм сахара в контейнере
        /// </summary>
        public int SugarVolume {
            get { return base.ContentVolume; }
        }

        /// <summary>
        /// Максимальный объм сахара в контейнере
        /// </summary>
        public int MaxSugarTankVolume {
            get { return base.MaximumVolume; }
        }

        public StandartSugarTank(int MaximumVolume) : base(MaximumVolume) {
        }

        public int TakeSugar(int Amount) {
            Mark("!!");
            return base.Take(Amount);
        }

        public int TakeSugar() {
            Mark();
            return base.Take();
        }

        public int AddSugar() {
            Mark();
            return base.Add();
        }

        public int AddSugar(int Amount) {
            Mark();
            return base.Add(Amount);
        }

        public override int Fill() {
            return base.Fill();
        }


        public override string ToString() {
            return string.Format("SugarTank => MaximumVolume: {0}, ContentVolume: {1}, IsFull: {2}, IsEmpty: {3} ",
                this.MaximumVolume, this.ContentVolume, IsFull, IsEmpty);
        }

        private void Mark() {
            Console.WriteLine("SugarTank =>");
        }

        private void Mark(string s) {
            Console.WriteLine(s);
        }

    }
}