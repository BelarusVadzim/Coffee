using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartSugarTank : Tank, ISugarTank {
        public StandartSugarTank(int FullVolume) : base(FullVolume) {
        }

        public int AmountOfSugar {
            get { return Amount; }
            set { Amount = value; }
        }

        public int AddSugar() {
            return Add();
        }

        public int AddSugar(int AmountOfSugarToAdd) {
            return Add(AmountOfSugarToAdd);
        }

        public int TakeSugar() {
            return Take();
        }

        public int TakeSugar(int AmountOfSugarToTake) {
            return Take(AmountOfSugarToTake);
        }
    }
}