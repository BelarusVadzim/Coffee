using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class ButtonPressedEventArgs: EventArgs {
        public string Message { get; set; }
        public int ButtonValue { get; set; }

        public ButtonPressedEventArgs(int ButtonValue, string Message) {
            this.ButtonValue = ButtonValue;
            this.Message = Message;
        }
    }
}