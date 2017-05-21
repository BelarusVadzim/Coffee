using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartCupCartridge : Tank, ICupCartridge {
        public StandartCupCartridge(int FullVolume) : base(FullVolume) {
        }

        private int AmountOfCups {
            get { return base.ContentVolume; }
        }

        public new bool IsEmpty {
            get { return base.IsEmpty; }
        }

        public int AddCup() {
            return Add();
        }

        public int AddCups(int AmountOfCups) {
            return Add(AmountOfCups);
        }

        public override int Fill() {
            return base.Fill();
        }


        public int TakeCup() {
            return base.Take();
        }

        public int TakeCups(int AmountOfCups) {
            return Take(AmountOfCups);
        }

    }
}