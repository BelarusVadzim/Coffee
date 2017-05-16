using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class CoffeeMakerController {
        public event EventHandler StateChanged;

        protected void MakeCoffee(CoffeeType type) {
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



        public void InputCommand(int CommandValue) {
            Console.WriteLine("Контроллер получил входящий параметр: {0}", CommandValue);
            int a = (int)CoffeeType.americano;
            MakeCoffee(CoffeeType.americano );
            switch (CommandValue) {
                case 1:
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }
    }
}