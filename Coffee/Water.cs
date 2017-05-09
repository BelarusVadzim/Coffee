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

        /// <summary>
        /// Температура воды
        /// </summary>
        public int Temperature { get; set; }
        /// <summary>
        /// Объм (мл)
        /// </summary>
        public Double Volume {
            get { return volume; }
            set {
                volume = value;
                mass = value*Density/1000;
            }
        }
        /// <summary>
        /// Массс (мг)
        /// </summary>
        public Double Mass {
            get { return mass; }
            set {
                mass = value;
                volume = value/(Density / 1000);
            }
        }


        public Liquid(LiquidType liqudeType, int Volume, int Temperature) {

            switch (liqudeType) {
                case LiquidType.Water:
                    Density = 1000;
                    HeatCapacity = 4187;
                    break;
                default:
                    break;
            }


            this.Volume = Volume;
            this.Temperature = Temperature;
        }

        public enum LiquidType {
            Water
        } 

    }
}