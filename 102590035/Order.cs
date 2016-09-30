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

        // get drink data in order
        public Drink GetDrink()
        {
            return _drink;
        }

        // get drink name in order
        public string GetDrinkName()
        {
            return _drink.GetName();
        }

        // get drink count in order
        public int GetCount()
        {
            return _count;
        }

        // increase drink count in order
        internal void Increase()
        {
            _count++;
        }

        // get drink price sum
        public int GetTotalPrice()
        {
            return _drink.GetPrice() * _count;
        }
    }
}
