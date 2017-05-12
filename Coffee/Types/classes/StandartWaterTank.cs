using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    /// <summary>
    /// Класс описывающий бак с водой для кофемашины
    /// </summary>
    public class StandartWaterTank : Tank {

        public StandartWaterTank(int FullVolume) 
            : base(FullVolume) {
        }
        //public new int AmountOfContent {
        //    get {
        //        if (WaterOfTank == null) return 0;
        //        return WaterOfTank.Volume;
        //    }
        //}

        public Water WaterOfTank { get; set; }

        /// <summary>
        /// Добавляет воду в указанном количестве мл за раз. Если объём воды превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountOfWaterToAdd">Количество добавляемой в бак воды (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество воды добавленой в бак</returns>
        public int AddWater(Water WaterToAdd) {
            Console.WriteLine("Попытка добавить {0} мл воды. Температура воды: {1}", WaterToAdd.Volume, WaterToAdd.Temperature);
            int ValueOfWaterThatCanBeAdded = default(int);
            ValueOfWaterThatCanBeAdded = base.Add(WaterToAdd.Volume);
            WaterToAdd.Volume = ValueOfWaterThatCanBeAdded;
            if (this.WaterOfTank == null) {
                this.WaterOfTank = WaterToAdd;
            } else {
                WaterToAdd.Volume = ValueOfWaterThatCanBeAdded;
                this.WaterOfTank.Add(WaterToAdd);
            }
            return ValueOfWaterThatCanBeAdded;
        }

        /// <summary>
        /// Удаляет воду в указанном количествеза раз (мл).Если объм воды достигает 0, то вызывается событие TankIsEmpty.
        /// </summary>
        /// <param name="AmountOfWaterToTake">Количество воды (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        /// <returns>Количество воды взятой из бака</returns>
        public int TakeWater(int AmountOfWaterToTake) {
            if(AmountOfWaterToTake >= WaterOfTank.Volume) {
                int V = WaterOfTank.Volume;
                WaterOfTank = null;
                return V;
            }
            this.WaterOfTank.Subtraction(AmountOfWaterToTake);
            return base.Take(AmountOfWaterToTake);
        }
        public int TakeWater() {
            return base.Take();
        }

        public override string ToString() {
            if(WaterOfTank != null)
            return string.Format("Объём бака: {0}, количество воды в баке: {1}, температура воды: {2}",
                base.MaximumVolume, this.WaterOfTank.Volume, this.WaterOfTank.Temperature);
            else
                return string.Format("Объём бака: {0} мл. Бак пуст.", base.MaximumVolume);
        }

        private void WaterInit(Water water) {
            if (water == null) return;
            water.ChangeVolume += WaterChangeVolume;
        }

        private void WaterChangeVolume(object Sender, WaterVolumeChangedEventArgs Args) {
            base.ContentVolume = Args.NewVolume;
        }
    }
}