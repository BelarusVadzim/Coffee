using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Keyboard {

       // public event EventHandler<ButtonPressedEventArgs> ButtonPressed;

        public List<Button> Buttons { get; set; }
        public string TextMessage { get; set; }
        public CoffeeMakerController Controller { get; private set; }
        public void ConnectToController(CoffeeMakerController Controller) {
            this.Controller = Controller;
        }

        public Keyboard(List<Button> Buttons) {
            this.Buttons = Buttons;
            foreach (var item in Buttons) {
                item.Pressed += (o, i) => Controller?.InputCommand(i.ButtonValue);
            }
        }


       

        /// <summary>
        /// Вызывает событие ButtoPressed
        /// </summary>
        /// <param name="button">Кнопка, которая была нажата</param>
        //public void PressButton(Button button) {
        //    if(ButtonPressed != null) {
        //        ButtonPressedEventArgs arg = new ButtonPressedEventArgs();
        //        arg.ButtonValue = button.Value;
        //        ButtonPressed(this, arg);
        //    }

        //}
    }
}