using System;

namespace Coffee {
    public interface ICoffeeMakerController {
        event EventHandler<string> StateChanged;

        void InputCommand(CoffeeMaker.ButtonsType CommandValue);
    }
}