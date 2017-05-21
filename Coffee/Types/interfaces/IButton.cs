using System;

namespace Coffee {
    public interface IButton {
        string Name { get; set; }
        CoffeeMaker.ButtonsType Value { get; set; }


        event EventHandler<ButtonPressedEventArgs> Pressed;

        void Press();
        void Block();
        void UnBlock();
    }
}