using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class DrinkAddition
    {
        private string _name;
        private int _price;

        // Initialize drinkAddition
        public DrinkAddition(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        // get addition
        public DrinkAddition GetAddition()
        {
            return this;
        }

        // get drinkAddition name
        public String GetName()
        {
            return _name;
        }

        // get drinkAddition price
        public int GetPrice()
        {
            return _price;
        }
    }
}
