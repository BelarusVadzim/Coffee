using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class StandartKeyboard {

       // public event EventHandler<ButtonPressedEventArgs> ButtonPressed;

        
        public Dictionary<ButtonsType, Button>   Buttons { get; set; }
        public string TextMessage { get; set; }
        public CoffeeMakerController Controller { get; private set; }
        public Button this[ButtonsType BType] {
            set {
                Buttons[BType] = value;
            }

            get {
                return Buttons[BType];
            }
        }

        public void ConnectToController(CoffeeMakerController Controller) {
            this.Controller = Controller;
        }

        public StandartKeyboard(Dictionary<ButtonsType, Button> Buttons) {
            this.Buttons = Buttons;
            foreach (var item in Buttons) {
                item.Value.Pressed += (o, i) => Controller?.InputCommand(i.ButtonValue);
            }
        }
    }
}