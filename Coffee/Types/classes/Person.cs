using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coffee {
    public class Person {
        public string Name {
            get => default(string);
            set {
            }
        }

        public byte Age {
            get => default(int);
            set {
            }
        }

        public bool WantCoffee {
            get => default(bool);
            set {
            }
        }

        public CoffeeMaker.ButtonsType FavoritCoffeeType {
            get => default(int);
            set {
            }
        }
    }
}