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
        private int _count;

        // Initialize drink
        public Drink(string name, int price)
        {
            this._name = name;
            this._price = price;
            this._count = 0;
        }

        // get drink name
        public String GetName()
        {
            return _name;
        }

        // get drink price
        public int GetPrice()
        {
            return _price;
        }

        // get drinks count
        public int GetCount()
        {
            return _count;
        }

        // increase drinks count
        internal void IncreaseDrinksCount()
        {
            _count++;
        }
    }
}
