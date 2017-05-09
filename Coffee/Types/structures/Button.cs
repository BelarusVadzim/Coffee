using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public struct Button {
        public Button(int Value, string Name) {
            this.Value = Value;
            this.Name = Name;
        }

        public int Value {
            get => default(int);
            set {
            }
        }

        public string Name {
            get => default(string);
            set {
            }
        }
    }
}