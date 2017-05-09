using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Liquid {

        /// <summary>
        /// Тепломкость. Сколько джоулей требуется для изменения одного кг воды на 1 градус Кельвина.
        /// </summary>
        private Double volume = default(Double);
        private Double mass = default(Double);


        /// <summary>
        /// Плотность жидкости
        /// </summary>
        public Double Density { get; private set; }
        public Double HeatCapacity { get; private set; }
        public LiquidType CurrentLiquideTye { get; private set; }

        /// <summary>
        /// Температура воды
        /// </summary>
        public Double Temperature { get; private set; }
        /// <summary>
        /// Объм (мл)
        /// </summary>
        public Double Volume {
            get { return volume; }
            private set {
                volume = value;
                mass = value*Density/1000;
            }
        }
        /// <summary>
        /// Массс (мг)
        /// </summary>
        public Double Mass {
            get { return mass; }
            private set {
                mass = value;
                volume = value/(Density / 1000);
            }
        }


        public Liquid(LiquidType liqudeType, Double Volume, Double Temperature) {

            switch (liqudeType) {
                case LiquidType.Water:
                    this.CurrentLiquideTye = LiquidType.Water;
                    Density = 1000;
                    HeatCapacity = 4187;
                    break;
                default:
                    break;
            }


            this.Volume = Volume;
            this.Temperature = Temperature;
        }

        /// <summary>
        /// Прибавление к жидкости указанной жидкости.
        /// </summary>
        /// <param name="L">Жидкость которую добавляем в текущую. Должна быть такого же типа.</param>
        public void Add(Liquid L) {
            if (L.CurrentLiquideTye != this.CurrentLiquideTye) throw new Exception("Попытка сложить жидкости разных типов");
            this.volume += L.volume;
            this.Temperature = (this.Temperature * this.mass + L.Temperature * L.mass) / (this.mass + L.mass);
        }

        /// <summary>
        /// Вычитаем жидкость из имеющейся. (мл)
        /// </summary>
        /// <param name="Volume">Объём жидкости, который нужно вычесть</param>
        /// <returns>Жидкость которую вычли.</returns>
        public Liquid Sub(double Volume) {
            if (Volume > this.volume) throw new Exception("Попытка удалить жидкости больше чем есть");
            this.volume -= Volume;
            Liquid result = new Liquid(this.CurrentLiquideTye, Volume, this.Temperature);
            return result;
        }

        



        public enum LiquidType {
            Water
        } 

    }
}