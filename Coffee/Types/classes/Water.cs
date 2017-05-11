using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Water {

        private Double mass = default(Double);
        private int volume = default(int);

        /// <summary>
        /// Тепломкость. Сколько джоулей требуется для изменения одного кг воды на 1 градус Кельвина.
        /// </summary>
        public Double HeatCapacity { get; private set; }

        /// <summary>
        /// Плотность жидкости
        /// </summary>
        public Double Density { get; private set; }

        /// <summary>
        /// Температура воды
        /// </summary>
        public Double Temperature { get; private set; }

        /// <summary>
        /// Объм воды (мл)
        /// </summary>
        public int Volume {
            get { return volume; }
            set {
                if (value < 0) throw new Exception("Объём должен быть больше нуля");
                volume=value;
                mass = value * Density / 1000;   //Сделать, чтобы можно было задавать только через метод
            }   
        }

        /// <summary>
        /// Массс (мг)
        /// </summary>
        public Double Mass {
            get { return mass; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="Volume">Объм создаваемой воды</param>
        /// <param name="Temperature">Температура создаваемой воды</param>
        public Water(int Volume, Double Temperature){

           // this.CurrentContentType = ContentType.Water;
            Density = 1000;
            HeatCapacity = 4187;
            this.Volume = Volume;
            this.Temperature = Temperature;
        }

        /// <summary>
        /// Прибавление к воде указанной воды.
        /// </summary>
        /// <param name="WaterToAdd">Вода которую добавляем в текущую.</param>
        public  void Add(Water WaterToAdd) {
            this.Temperature = (this.Temperature * this.mass + WaterToAdd.Temperature * WaterToAdd.mass) / (this.mass + WaterToAdd.mass);
            this.Volume += WaterToAdd.Volume;
        }



        /// <summary>
        /// Вычитаем воду из имеющейся. (мл)
        /// </summary>
        /// <param name="Volume">Объём воды, который нужно вычесть</param>
        /// <returns>Вода которую вычли.</returns>
        public Water Subtraction(int Volume) {
            this.Volume -= Volume; 
            Water result =  new Water(Volume, this.Temperature);
            return result;
        }

        public override string ToString() {
            return string.Format("Объём воды:{0}; Температура воды:{1}", this.Volume, this.Temperature);
        }


    }
}