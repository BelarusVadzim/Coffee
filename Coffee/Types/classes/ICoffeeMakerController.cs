using System;

namespace Coffee {
    public interface ICoffeeMakerController {
        event EventHandler StateChanged;

        void InputCommand(CoffeeMaker.ButtonsType CommandValue);
    }
}