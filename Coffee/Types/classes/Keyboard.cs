using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Keyboard {

        public event ButtonPressedHanler ButtonPressed;

        public List<Button> Buttons {
            get => default(List<Button>);
            set {
            }
        }

        public string TextMessage {
            get => default(string);
            set {
            }
        }
        /// <summary>
        /// Вызывает событие ButtoPressed
        /// </summary>
        /// <param name="button">Кнопка, которая была нажата</param>
        public void PressButton(Button button) {
            if(ButtonPressed != null) {
                ButtonPressedEventArgs arg = new ButtonPressedEventArgs();
                arg.ButtonValue = button.Value;
                ButtonPressed(this, arg);
            }
                
        }
    }
}