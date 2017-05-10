using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    /// <summary>
    /// Класс описывающий бак с водой для кофемашины
    /// </summary>
    public class StandartWaterTank :Tank, IWaterTank {

        
        public StandartWaterTank(int FullVolume) : base(FullVolume) {
        }
        public int CurrentAmountOfWater {
            get {
                if (TankContent == null) return 0;
                return TankContent.Volume; }
        }
        public Water TankWater {
            get {return  TankContent as Water; }
            set { TankContent = value; }
        }




        /// <summary>
        /// Добавляет воду в указанном количестве мл за раз. Если объём воды превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountOfWaterToAdd">Количество добавляемой в бак воды (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество воды добавленой в бак</returns>
        //public double AddWater(double AmountOfWaterToAdd) {
        //    return Add(AmountOfWaterToAdd);
        //}
        public int AddWater(Water WaterToAdd) {
            int result = default(int);
            result = Add(WaterToAdd.Volume);
            this.TankContent.Add(WaterToAdd.Subtraction(result));
            return result;
        }


       
        //public double AddWater() {
        //    return Add();
        //}

        /// <summary>
        /// Удаляет воду в указанном количествеза раз (мл).Если объм воды достигает 0, то вызывается событие TankIsEmpty.
        /// </summary>
        /// <param name="AmountOfWaterToTake">Количество воды (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        /// <returns>Количество воды взятой из бака</returns>
        public int TakeWater(int AmountOfWaterToTake) {
            this.TankContent.Subtraction(AmountOfWaterToTake);
            return Take(AmountOfWaterToTake);
        }
        public int TakeWater() {
            return Take();
        }



        

  
    }
}