using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Types {
    public abstract class Tank{

        
        /// <summary>
        /// Событие возникающее, когда бак становится пустым.
        /// </summary>
        public event EventHandler TankIsEmpty;
        /// <summary>
        /// Событие возникающее, когда бак становится полностью заполненым
        /// </summary>
        public event EventHandler TankIsFull;

        /// <summary>
        /// Объём бака
        /// </summary>
        public int MaximumVolume { get; }

        protected IContent TankContent { get; set; }


      
        /// <summary>
        /// Количество содержимого в баке.
        /// </summary>
        public int Amount {
            get {
                if (TankContent == null) return 0;
                return TankContent.Volume;}
        }

        /// <summary>
        /// Возвращает True если бак пуст.
        /// </summary>
        public bool IsEmpty { get; private set; }

        /// <summary>
        /// Возвращает True если бак полон.
        /// </summary>
        public bool IsFull { get; private set; }

        public Tank(int MaximumVolume) {
            this.MaximumVolume = MaximumVolume;
            //this.Amount = 0;
            this.IsEmpty = true;
            this.IsFull = false;
            this.TankContent = new Content(0);
        }



        /// <summary>
        /// Добавляет T в указанном количестве мл за раз. Если объём T превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountToAdd">Количество добавляемой в бак T (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество T добавленой в бак</returns>
        //protected int Add(int AmountToAdd) {
        //    if (AmountToAdd <= 0)
        //        throw new Exception("Amount should be a positive value.");
        //    int rest = 0;
        //    Console.WriteLine("Try to add {0} mls", AmountToAdd);
        //    //Amount += AmountToAdd;
        //    IsEmpty = false;
        //    if (Amount>= MaximumVolume) {
        //        rest = Amount - MaximumVolume;
        //        //Amount = MaximumVolume;
        //        IsFull = true;
        //        if (TankIsFull != null)
        //            TankIsFull(this, new EventArgs());
        //    }
        //    return AmountToAdd - rest;
        //}
        //protected int Add() {
        //    return Add(10);
        //}

        /// <summary>
        /// Добавляет содержимое в указанном количестве мл за раз. Если объём содержимого превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountToAdd">Количество добавляемой в бак T (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество T добавленой в бак</returns>
        protected int Add(int AmountToAdd) {
            if (AmountToAdd <= 0)
                throw new Exception("Amount should be a positive value.");
            int result = AmountToAdd;  //result переменная, которая показывает какое количество содержимого будет добавлено с учтом вместимости бака
            Console.WriteLine("Try to add {0} mls", AmountToAdd);
            IsEmpty = false;
            if (Amount + AmountToAdd >= MaximumVolume) {
                result = Amount + AmountToAdd - MaximumVolume;
                IsFull = true;
            }
            this.TankContent.Add(new Content(result));
            if (IsFull) {
                if (TankIsFull != null)
                    TankIsFull(this, new EventArgs());
            }
            return result;   //Показывается сколько мл содержимого смогло быть добавлено. (с учтом вместимости бака)
        }
        protected int Add() {
            return Add(10);
        }




        ///// <summary>
        ///// Удаляет T в указанном количестве за раз (мл). Если объм T достигает 0, то вызывается событие TankIsEmpty.
        ///// </summary>
        ///// <param name="AmountToTake">Количество T (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        ///// <returns>Количество T взятого из бака</returns>
        //protected int Take(int AmountToTake) {
        //    if (AmountToTake <= 0)
        //        throw new Exception("Amount should be a positive value.");
        //    int rest = AmountToTake;
        //    IsFull = false;
        //    Console.WriteLine("Try to teake {0} mls", AmountToTake);
        //    //Amount -= AmountToTake;
        //    if (Amount <= 0) {
        //        rest = AmountToTake + Amount;
        //        //Amount = 0;
        //        IsEmpty = true;
        //        if (TankIsEmpty != null)
        //            TankIsEmpty(this, new EventArgs());
        //    }
        //    return rest;
        //}
        ///// <summary>
        ///// Test
        ///// </summary>
        ///// <returns></returns>
        //protected int Take() {
        //    return Take(10);
        //}


        /// <summary>
        /// Удаляет содержимое в указанном количестве за раз (мл). Если объм содержимого достигает 0, то вызывается событие TankIsEmpty.
        /// </summary>
        /// <param name="AmountToTake">Количество содержимого (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        /// <returns>Количество содержимого взятого из бака</returns>
        protected int Take(int AmountToTake) {
            if (AmountToTake <= 0)
                throw new Exception("Amount should be a positive value.");
            int rest = AmountToTake;
            IsFull = false;
            Console.WriteLine("Try to teake {0} mls", AmountToTake);
            if (Amount- AmountToTake <= 0) {
                rest = Amount;
                TankContent.Subtraction(rest);
                IsEmpty = true;
                if (TankIsEmpty != null)
                    TankIsEmpty(this, new EventArgs());
            }
            if(IsEmpty)
                if (TankIsEmpty != null)
                    TankIsEmpty(this, new EventArgs());
            return rest;
        }
        protected int Take() {
            return Take(10);
        }



        public override string ToString() {
            return string.Format("FullVolume: {0}, Amount: {1}",
                this.MaximumVolume, this.Amount);
        }
    }
}
