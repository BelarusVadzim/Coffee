using System.Collections.Generic;

namespace Coffee {
    public interface IKeyboard {
        IButton this[CoffeeMaker.ButtonsType BType] { get; set; }

        Dictionary<CoffeeMaker.ButtonsType, IButton> Buttons { get; set; }
        ICoffeeMakerController Controller { get; }

        void ConnectToController(StandartCoffeeMakerController Controller);
    }
}