using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee.Types {
    public class Tank{

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
        protected int MaximumVolume { get; }

        /// <summary>
        /// Количество содержимого в баке.
        /// </summary>
        protected int ContentVolume { get; set; }


        /// <summary>
        /// Возвращает True если бак пуст.
        /// </summary>
        protected bool IsEmpty { get; private set; }

        /// <summary>
        /// Возвращает True если бак полон.
        /// </summary>
        protected bool IsFull { get; private set; }

        public Tank(int MaximumVolume) {
            this.MaximumVolume = MaximumVolume;
            //this.Amount = 0;
            this.IsEmpty = true;
            this.IsFull = false;
            // this.TankContent = new Content(0);
        }


        /// <summary>
        /// Добавляет содержимое в указанном количестве мл за раз. Если объём содержимого превышает объём бака, то вызывается событие TankIsFull.
        /// </summary>
        /// <param name="AmountToAdd">Количество добавляемой в бак T (мл). По-умолчанию добавляется 10 мл. Не может быть отрицательным или 0.</param>
        /// <returns>Количество T добавленой в бак</returns>
        protected int Add(int AmountToAdd) {
            if (AmountToAdd <= 0)
                throw new ArgumentException("AmountToAdd should be a positive value.");
            if (IsFull) {
                TankIsFull?.Invoke(this, new EventArgs());
                return 0;
            }
            int result = AmountToAdd;  //result переменная, которая показывает какое количество содержимого будет добавлено с учтом вместимости бака
            IsEmpty = false;
            if (ContentVolume + AmountToAdd >= MaximumVolume) {         // Если содержимое бака + добавдяемое больше чем объм бака
                result = MaximumVolume - ContentVolume;                 // При переполнении бака переменной result автоматически присвается значение того объма, который был свободен до операции
                ContentVolume = MaximumVolume;
                IsFull = true;
            } 
            else {
                ContentVolume += AmountToAdd;
            }
            if (IsFull) {
                TankIsFull?.Invoke(this, new EventArgs());
            }
            return result;   //Показывается сколько мл содержимого смогло быть добавлено. (с учтом вместимости бака)
        }
        protected int Add() {
            return Add(10);
        }

        public virtual int Fill() {
            int result = default(int);
            while (!IsFull) {
                result += Add();
            }
            return result;
        }



        /// <summary>
        /// Удаляет содержимое в указанном количестве за раз (мл). Если объм содержимого достигает 0, то вызывается событие TankIsEmpty.
        /// </summary>
        /// <param name="AmountToTake">Количество содержимого (мл) которое удаляется из бака. Не может быть отрицательным или 0.</param>
        /// <returns>Количество содержимого взятого из бака</returns>
        protected int Take(int AmountToTake) {
            if (AmountToTake <= 0)
                throw new Exception("Amount should be a positive value.");
            if (IsEmpty) {
                TankIsEmpty?.Invoke(this, new EventArgs());
                return 0;
            }
            int result = AmountToTake;                 // Число указывающее сколько содержимого мы берем.
            if(ContentVolume - AmountToTake < MaximumVolume)
            IsFull = false;
            if (ContentVolume- AmountToTake <= 0) {  //Если остаток в баке меньше того количества которое мы хотим взять
                result = ContentVolume;                // Остаток бака полностью переходит в число содержимого, которое мы хотели ихъять
                ContentVolume = 0; ;                 // Содержімому бака прісваіваем 0;
                IsEmpty = true;
                TankIsEmpty?.Invoke(this, new EventArgs());  // Вызываем событие TankIsEmpty
            } else {
                ContentVolume -= AmountToTake;
            }
            return result;                                 
        }
        protected int Take() {
            return Take(10);
        }

        public override string ToString() {
            return string.Format("MaximumVolume: {0}, ContentVolume: {1}, IsFull: {2}, IsEmpty: {3} ",
                this.MaximumVolume, this.ContentVolume, IsFull, IsEmpty);
        }
    }
}
