using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Drink
    {
        private string _name;
        private int _price;

        // Initialize drink
        public Drink(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        public String GetName()
        {
            return _name;
        }

        public int GetPrice()
        {
            return _price;
        }
    }
}
