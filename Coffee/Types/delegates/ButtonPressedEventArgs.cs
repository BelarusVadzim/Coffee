using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class ButtonPressedEventArgs: EventArgs {
        public string Message { get; set; }
        public ButtonsType ButtonValue { get; set; }

        public ButtonPressedEventArgs(ButtonsType ButtonValue, string Message) {
            this.ButtonValue = ButtonValue;
            this.Message = Message;
        }
    }
}