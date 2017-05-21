using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class Button : IButton {

        private bool blocked = default(bool);

        public ButtonsType Value { get; set; }
        public string Name { get; set; }

        public event EventHandler<ButtonPressedEventArgs> Pressed;
        public void Press() {
            if(!blocked)
                Pressed?.Invoke(this, new ButtonPressedEventArgs(this.Value, this.Name));
        }

        public void Block() {
            blocked = true;
        }
        public void UnBlock() {
            blocked = false;
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