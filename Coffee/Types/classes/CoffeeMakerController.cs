using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class CoffeeMakerController : ICoffeeMakerController {
        public event EventHandler StateChanged;

        protected void MakeCoffee(ButtonsType type) {
            Console.WriteLine(type.ToString());          
        }

        protected void PrepareCup() {
            throw new System.NotImplementedException();
        }

        protected void PrepareCoffee() {
            throw new System.NotImplementedException();
        }

        protected void PrepareSugar() {
            throw new System.NotImplementedException();
        }

        protected void PrepareWater() {
            throw new System.NotImplementedException();
        }

        protected void PrepareMilk() {
            throw new System.NotImplementedException();
        }

        protected void ChangeState() {
            throw new System.NotImplementedException();
        }



        public void InputCommand(ButtonsType CommandValue) {
            Console.WriteLine("Контроллер получил входящий параметр: {0}", CommandValue);
            MakeCoffee(CommandValue);
            switch (CommandValue) {
                case  ButtonsType.americano:
                    break;
                case  ButtonsType.cappuccino:
                    break;
                default:
                    break;
            }
        }
    }
}