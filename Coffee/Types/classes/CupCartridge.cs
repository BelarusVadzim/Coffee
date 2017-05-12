using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class CupCartridge : Tank, ICupCartridge {
        public CupCartridge(int FullVolume) : base(FullVolume) {
        }

        public int AmountOfCups {
            get { return ContentVolume; }
            //set { Amount = value; }
        }

        public int AddCup() {
            return Add();
        }

        public int AddCups(int AmountOfCups) {
            return Add(AmountOfCups);
        }

        public int TakeCup() {
            return Take();
        }

        public int TakeCups(int AmountOfCups) {
            return Take(AmountOfCups);
        }
    }
}