﻿using Coffee.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Coffee.CoffeeMaker;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMaker COFFEEMAKER = CoffeeMakerFactory.CreateCoffeeMaker();

            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType2].Press();
            COFFEEMAKER.Keyboard[ButtonsType.CoffeeType3].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.IncreaseSugar].Press();
            COFFEEMAKER.Keyboard[ButtonsType.Start].Press();

            Console.WriteLine(COFFEEMAKER.ToString());
        }
    }
}
