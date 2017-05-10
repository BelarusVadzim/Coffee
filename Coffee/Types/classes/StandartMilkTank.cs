using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class StandartMilkTank : Tank, IMilkTank {
        public StandartMilkTank(int FullVolume) : base(FullVolume) {
        }
        public int AmountOfMilk {
            get { return Amount; }
           // set { Amount = value; }
        }

        /// <summary>
        /// Добавляет молоко в указанном количестве мл за раз. Если объём молока превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountOfMilkToAdd">Количество добавляемого в бак молока (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество воды добавленой в бак</returns>
        public int AddMilk(int AmountOfMilkToAdd) {
            return Add(AmountOfMilkToAdd);
        }
        public int AddMilk() {
            return Add();
        }

        /// <summary>
        /// Удаляет молоко в указанном количествеза раз (мл).Если объм молока достигает 0, то вызывается событие TankIsEmpty.
        /// </summary>
        /// <param name="AmountOfMilkToTake">Количество молока (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        /// <returns>Количество молока взятого из бака</returns>
        public int TakeMilk(int AmountOfMilkToTake) {
            return Take(AmountOfMilkToTake);
        }
        public int TakeMilk() {
            return Take();
        }
    }
}