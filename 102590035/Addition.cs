using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Addition
    {
        private string _name;
        private int _price;

        // Initialize addition
        public Addition(string name, int price)
        {
            this._name = name;
            this._price = price;
        }

        // get addition
        public Addition GetAddition()
        {
            return this;
        }

        // get addition name
        public String GetName()
        {
            return _name;
        }

        // get addition price
        public int GetPrice()
        {
            return _price;
        }
    }
}
