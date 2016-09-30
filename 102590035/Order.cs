using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    public class Order
    {
        private Drink _drink;
        private int _count;

        public Order(Drink drink)
        {
            _drink = drink;
            _count = 1;
        }

        public Drink GetDrink()
        {
            return _drink;
        }

        public string GetDrinkName()
        {
            return _drink.GetName();
        }

        public int GetCount()
        {
            return _count;
        }

        internal void Increase()
        {
            _count++;
        }

        public int GetTotalPrice()
        {
            return _drink.GetPrice() * _count;
        }
    }
}
