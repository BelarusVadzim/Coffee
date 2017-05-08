using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class ButtonPressedEventArgs: EventArgs {
        public string Message {
            get => default(string);
            set {
            }
        }

        public int ButtonValue {
            get => default(int);
            set {
            }
        }
    }
}