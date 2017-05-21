﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Coffee.CoffeeMaker;

namespace Coffee {
    public class StandartCoffeeMakerController : ICoffeeMakerController {

        private const int maxSugar = 15; 
        public event EventHandler<string> StateChanged;
        private int sugarValue = default(int);
        private int coffeeBeens = default(int);
        private int water = default(int);
        private int milk = default(int);
        private CoffeeType coffeeType = default(CoffeeType);
        protected IBoiler boiler = default(IBoiler);
        protected IWaterTank waterTank = default(IWaterTank);
        protected ICoffeeTank coffeeTank = default(ICoffeeTank);
        protected ISugarTank sugarTank = default(ISugarTank);
        protected ICupCartridge cupCartridge = default(ICupCartridge);
        protected IKeyboard keyboard = default(IKeyboard);
        protected IMilkTank milkTank = default(IMilkTank);

        private string WaterErr = "", SugarErr = "", MilkErr = "", CoffeeBeensErr = "", SystemErr = "";

        public void Connect(IBoiler Boiler, IWaterTank WaterTank, ICoffeeTank CoffeeTank,
           IMilkTank MilkTank, ISugarTank SugarTank, ICupCartridge CupCartridge, IKeyboard Keyboard) {
            this.boiler = Boiler;
            this.waterTank = WaterTank;
            this.coffeeTank = CoffeeTank;
            this.milkTank = MilkTank;
            this.sugarTank = SugarTank;
            this.cupCartridge = CupCartridge;
            this.keyboard = Keyboard;
            this.keyboard.ConnectToController(this);
        }


        
        protected void CheckSugar() {
            if (sugarTank.IsEmpty) {
                SugarErr = "No more sugar";
                keyboard[ButtonsType.IncreaseSugar].Block();
            }
            else {
                SugarErr = "";
                keyboard[ButtonsType.IncreaseSugar].UnBlock();
            }
        }
        protected void ChekWater() {
            if (waterTank.IsEmpty) {
                WaterErr = "No more water";
                foreach (Button item in keyboard) {
                    item.Block();
                }
            }
            else {
                WaterErr = "";
                keyboard[ButtonsType.IncreaseSugar].UnBlock();
            }
        }
        protected void CheckMilk() {
            if (milkTank.IsEmpty) {
                MilkErr = "No more milk";
                keyboard[ButtonsType.CoffeeType2].Block();
            }
            else {
                SugarErr = "";
                keyboard[ButtonsType.IncreaseSugar].UnBlock();
            }
        }


        protected void MakeCoffee() {
            SetCoffeeTypeParams();
            PrepareCup();
            PrepareWater();
            PrepareCoffeeBeens();
            //PrepareMilk();
            //IncreaseSugar();
            StateChanged(this, "Take your cup of coffee");
        }

        protected void PrepareCup() {

            if (!coffeeTank.IsEmpty) {
                cupCartridge.TakeCup();
                StateChanged?.Invoke(this, "Cup is ready");
            }
            else  StateChanged?.Invoke(this, "No cups");
        }

        protected void SetCoffeeTypeParams() {

            switch (coffeeType) {
                case CoffeeType.Espesso:
                    SetUpCoffeeParams(150, 10, 0);
                    break;
                case CoffeeType.Americano:
                    SetUpCoffeeParams(250, 10, 0);
                    break;
                case CoffeeType.Cappuccino:
                    SetUpCoffeeParams(150, 10, 50);
                    break;
                default:
                    break;
            }
        }

        private void SetUpCoffeeParams(int Water, int CoffeeBeens, int Milk) {
            water = Water;
            coffeeBeens = CoffeeBeens;
            milk = Milk;
        }

        protected void PrepareCoffeeBeens() {
            if (!cupCartridge.IsEmpty) {
                coffeeTank.TakeCoffee(10);
                StateChanged?.Invoke(this, "Coffee beens is ready");
            }

            else StateChanged?.Invoke(this, "No coffee");
        }

        protected void IncreaseSugar() {
            if (sugarValue < maxSugar) {
                sugarValue += 5;
                StateChanged?.Invoke(this, "Сахар увеличен");
            }
            else {
                sugarValue = maxSugar;
                StateChanged?.Invoke(this, "Максимальное количество сахара");
            }
        }

        protected void ReduceSugar() {
            if (sugarValue > 0) {
                sugarValue -= 5;
                StateChanged?.Invoke(this, "Сахар уменшен");
            }
            else {
                sugarValue = 0;
                StateChanged?.Invoke(this, "Без сахара");
            }
        }

        protected void PrepareWater() {
            if (!waterTank.IsEmpty) {
                waterTank.TakeWater(10);
                StateChanged?.Invoke(this, "Water is ready");
            }
            else StateChanged?.Invoke(this, "No water");

        }

        protected void PrepareMilk() {
            if (!milkTank.IsEmpty) {
                milkTank.TakeMilk(10);
                StateChanged?.Invoke(this, "Milk is ready");
            }
            else StateChanged?.Invoke(this, "No milk");
        }




        protected void ChangeState() {
            //throw new System.NotImplementedException();
        }



        public void InputCommand(ButtonsType CommandValue) {
            Console.WriteLine("Контроллер получил входящий параметр: {0}", CommandValue);
 
            switch (CommandValue) {
                case  ButtonsType.Start:
                    MakeCoffee();
                    break;
                case  ButtonsType.CoffeeType1:
                    coffeeType = CoffeeType.Americano;
                    break;
                case ButtonsType.CoffeeType2:
                    coffeeType = CoffeeType.Cappuccino;
                    break;
                case ButtonsType.CoffeeType3:
                    coffeeType = CoffeeType.Espesso;
                    break;
                case ButtonsType.IncreaseSugar:
                    if (this.sugarTank.IsEmpty) IncreaseSugar();
                    else StateChanged(this, "No more sugar");
                        break;
                case ButtonsType.ReduceSugar:
                    ReduceSugar();
                    break;
                default:
                    break;
            }
        }
    }
}