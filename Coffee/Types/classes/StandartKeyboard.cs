using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class StandartKeyboard : IKeyboard {

       // public event EventHandler<ButtonPressedEventArgs> ButtonPressed;

        
        public Dictionary<ButtonsType, IButton>   Buttons { get; set; }
        //public string TextMessage { get; set; }
        public ICoffeeMakerController Controller { get; private set; }
        public IButton this[ButtonsType BType] {
            set {
                Buttons[BType] = value;
            }

            get {
                return Buttons[BType];
            }
        }

        public void ConnectToController(StandartCoffeeMakerController Controller) {
            this.Controller = Controller;
        }

        public StandartKeyboard(Dictionary<ButtonsType, IButton> Buttons) {
            this.Buttons = Buttons;
            foreach (var item in Buttons) {
                item.Value.Pressed += (o, i) => Controller?.InputCommand(i.ButtonValue);
            }
        }
    }
}