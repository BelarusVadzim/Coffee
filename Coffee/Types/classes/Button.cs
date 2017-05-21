using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class Button : IButton {
        public ButtonsType Value { get; set; }
        public string Name { get; set; }

        public event EventHandler<ButtonPressedEventArgs> Pressed;
        public void Press() {
            Pressed?.Invoke(this, new ButtonPressedEventArgs(this.Value, this.Name));
        }

        public Button(ButtonsType Value, string Name) {
            this.Value = Value;
            this.Name = Name;
        }

        public override string ToString() {
            return string.Format("Name: {0}, Value: {1}", Name, Value);
        }
    }

    
}