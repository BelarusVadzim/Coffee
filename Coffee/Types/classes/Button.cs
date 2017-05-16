﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Button {
        public int Value { get; set; }
        public string Name { get; set; }

        public event EventHandler<ButtonPressedEventArgs> Pressed;
        public void Press() {
            Pressed?.Invoke(this, new ButtonPressedEventArgs(this.Value, this.Name));
        }

        public Button(int Value, string Name) {
            this.Value = Value;
            this.Name = Name;
        }
    }

    
}