using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class CupCartridge: IEnumerable<Cup> {

        private readonly int capacity;

        public Queue<Cup> Cups { get; }

        public int Capacity {
            get => capacity;
        }

        string s = "";

        public CupCartridge() {
            capacity = 80;
        }
        public CupCartridge(int Capacity) {
            capacity = Capacity;
        }


        public IEnumerator<Cup> GetEnumerator() {
            return ((IEnumerable<Cup>)Cups).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return ((IEnumerable<Cup>)Cups).GetEnumerator();
        }

        public void TakeCup() {
            if(Cups.Count() >0)
            Cups.Dequeue();
        }

        private bool AddCup() {
            if (Cups.Count < capacity) {
                Cups.Enqueue(new Cup());
                return true;
            }
            return false;
        }

        public int AddCups(int Amount) {
            int result = Amount;
            for (int i = 0; i < Amount; i++) {
                AddCup();
                result--;
                if (result <= 0) break;
            }
            Console.WriteLine("Добавлено {0} из {1} стаканчиков. В картридже {2} из {3} стаканчиков", result, Amount, Cups.Count, capacity);
            return result;
        }



        public int Reload() {
            throw new System.NotImplementedException();
        }
    }
}